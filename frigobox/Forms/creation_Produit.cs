using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frigobox.Forms
{
    public partial class creation_Produit : Form
    {
        private string chaineDeConnexion = "";
        enum etatValidationButton { normal, error, waiting, ok, errorDB };
        etatValidationButton previousState = etatValidationButton.normal;

        enum GetIDTable { SousCategorie, Unit, Categorie};
        enum GetNewIDTable { SousCategorie, Unit, Categorie, Produit };
        public creation_Produit(string connexionString = "")
        {
            InitializeComponent();
            if (connexionString == "")
            {
                toggle_validation(etatValidationButton.errorDB);
            }
            else
            {
                toggle_validation(etatValidationButton.normal);
                chaineDeConnexion = connexionString;
                initCategorieListe();
                initUnit();
            }

        }

        private void initCategorieListe()
        {
            string[] listeSousCatExistante = new string[] { };
            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            sql = "Select c.Nom_categorie from Categories as c;";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            Textbox_categorie.AutoCompleteCustomSource.Clear();
            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString();
                Textbox_categorie.AutoCompleteCustomSource.Add(Output);
            }
            dataReader.Close();
            cnn.Close();
            Textbox_categorie.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Textbox_categorie.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        public void initUnit()
        {
            string[] listeUniteExistante = new string[] { };
            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            sql = "Select Nom_unite from Unite_mesure;";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            Textbox_UniteProduit.AutoCompleteCustomSource.Clear();
            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString();
                Textbox_UniteProduit.AutoCompleteCustomSource.Add(Output);
            }
            dataReader.Close();
            cnn.Close();
            Textbox_UniteProduit.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Textbox_UniteProduit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void checkRemplissage()
        {
            etatValidationButton etatAAtribuer;
            bool stop = false;
            if (!(Textbox_nom.TextLength > 2
                && Textbox_categorie.Text != ""
                && Textbox_sous_categorie.Text != ""
                && Textbox_QuantiteInitial.Text != ""
                && Textbox_UniteProduit.Text != ""))
            {
                stop = true;
            }
            if (!stop)
            {
                etatAAtribuer = etatValidationButton.normal;
            }
            else
            {
                etatAAtribuer = etatValidationButton.waiting;
            }
            toggle_validation(etatAAtribuer);
        }

        private void toggle_validation(etatValidationButton etat)
        {
            if (previousState != etat)
            {
                string text = "";
                bool boutonActif = false;
                Color couleurBouton = Color.Purple;
                switch (etat)
                {
                    case etatValidationButton.error:
                        text = "Produit similaire existant";
                        boutonActif = false;
                        couleurBouton = Color.FromArgb(168, 56, 44);
                        break;
                    case etatValidationButton.normal:
                        text = "Valider l'ajout";
                        boutonActif = true;
                        couleurBouton = Color.FromArgb(22, 64, 92);
                        Label_nomProduit.Enabled = true;
                        Label_categorie.Enabled = true;
                        Label_SousCategorie.Enabled = true;
                        Label_UniteQuantite.Enabled = true;
                        Textbox_nom.Enabled = true;
                        Textbox_categorie.Enabled = true;
                        Textbox_sous_categorie.Enabled = true;
                        Textbox_UniteProduit.Enabled = true;
                        Textbox_QuantiteInitial.Enabled = true;
                        break;
                    case etatValidationButton.waiting:
                        text = "Valider l'ajout";
                        boutonActif = false;
                        couleurBouton = Color.FromArgb(22, 64, 92);
                        break;
                    case etatValidationButton.ok:
                        text = "Ajout validé";
                        boutonActif = false;
                        couleurBouton = Color.FromArgb(52, 152, 219);
                        break;
                    case etatValidationButton.errorDB:
                        text = "Chaine de connexion non transmise !";
                        couleurBouton = Color.FromArgb(168, 56, 44);
                        boutonActif = false;
                        break;
                }
                if (etat == etatValidationButton.errorDB)
                {
                    Label_nomProduit.Enabled = false;
                    Label_categorie.Enabled = false;
                    Label_SousCategorie.Enabled = false;
                    Label_UniteQuantite.Enabled = false;
                    Textbox_nom.Enabled = false;
                    Textbox_categorie.Enabled = false;
                    Textbox_sous_categorie.Enabled = false;
                    Textbox_UniteProduit.Enabled = false;
                    Textbox_QuantiteInitial.Enabled = false;
                }
                else
                {
                    Label_nomProduit.Enabled = true;
                    Label_categorie.Enabled = true;
                    Label_UniteQuantite.Enabled = true;
                    Textbox_nom.Enabled = true;
                    Textbox_categorie.Enabled = true;
                    Textbox_UniteProduit.Enabled = true;
                    Textbox_QuantiteInitial.Enabled = true;
                }
                previousState = etat;
                Label_Validation.Enabled = boutonActif;
                Label_Validation.Text = text;
                Label_Validation.BackColor = couleurBouton;
            }
        }

        private void QuantiteInitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NomTextbox_TextChanged(object sender, EventArgs e)
        {
            checkRemplissage();
        }

        private void ValidationLabel_Click(object sender, EventArgs e)
        {
            int nombreDeProduitSimilaire = getNumberOfSimilarItem(Textbox_nom.Text);
            if (nombreDeProduitSimilaire != 0)
            {
                toggle_validation(etatValidationButton.error);
            }
            else
            {
                SaveData();
                cleartextBox();
                toggle_validation(etatValidationButton.ok);
            }
        }

        private int getNumberOfSimilarItem(string EnterText)
        {
            String sql, Output = "";
            string productName = EnterText.ToLower();
            sql = "Select count(Id_produit) from Produits where Nom_produit='" + productName + "';";
            Output = getFromDB(sql);
            int nombreDeProduitSimilaire = Convert.ToInt32(Output);
            return nombreDeProduitSimilaire;
        }

        private void cleartextBox()
        {
            Textbox_categorie.Text = "";
            Textbox_nom.Text = "";
            Textbox_sous_categorie.Text = "";
            Textbox_QuantiteInitial.Text = "";
            Textbox_UniteProduit.Text = "";
        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            checkRemplissage();
        }

        private void EnableSousCatTextBox()
        {
            Textbox_sous_categorie.Text = "";
            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            string Categorie = Textbox_categorie.Text.ToLower();
            sql = "Select sc.Nom_sous_categorie from Sous_categories as sc join Categories as c on (sc.Id_categorie_fk = c.Id_categorie) where (c.Nom_categorie = '" + Categorie + "');";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            Textbox_sous_categorie.AutoCompleteCustomSource.Clear();
            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString();
                Textbox_sous_categorie.AutoCompleteCustomSource.Add(Output);
            }
            dataReader.Close();
            cnn.Close();
            Textbox_sous_categorie.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Textbox_sous_categorie.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Textbox_sous_categorie.Enabled = true;
            Label_SousCategorie.Enabled = true;
        }

        private void SousCatTextbox_TextChanged(object sender, EventArgs e)
        {
            if (Textbox_categorie.Text != "")
            {
                EnableSousCatTextBox();
            }
            else
            {
                Textbox_sous_categorie.Text = "";
                Textbox_sous_categorie.Enabled = false;
                Label_SousCategorie.Enabled = false;
            }
        }

        private void SaveData()
        {
            if(!checkUnit())
            {
                addUnit();
            }
            if(!checkCategorie())
            {
                addCategorie();
            }
            if(!checkSousCategorie())
            {
                addSousCategorie();
            }
            addProduit();
        }

        private bool checkUnit()
        {
            string unitName = Textbox_UniteProduit.Text.ToLower();
            string sql = "Select count(Id_unite) from Unite_mesure where Nom_unite='" + unitName + "';";
            return checkExistingElement(sql);
        }

        private bool checkCategorie()
        {
            string CategorieName = Textbox_categorie.Text.ToLower();
            string sql = "Select count(Id_categorie) from Categories where Nom_categorie='" + CategorieName + "';";
            return checkExistingElement(sql);
        }

        private bool checkSousCategorie()
        {
            string SousCategorieName = Textbox_sous_categorie.Text.ToLower();
            string sql = "Select count(Id_sous_categorie) from Sous_categories where Nom_sous_categorie='" + SousCategorieName + "';";
            return checkExistingElement(sql);
        }

        private bool checkExistingElement(string sql)
        {
            string Output = "";
            Output = getFromDB(sql);
            int nombreDeSousCategorieSimilaire = Convert.ToInt32(Output);
            if (nombreDeSousCategorieSimilaire == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addUnit()
        {
            int IdMax = getNewId(GetNewIDTable.Unit);
            string sql = "Insert into Unite_mesure (Id_unite, Nom_unite) values ("+IdMax +", '" + Textbox_UniteProduit.Text.ToLower() + "');";
            addToDB(sql);
            initUnit(); // raffraichi la liste de préremplissage du programme en ajoutant la nouvelle unité
        }

        private void addCategorie()
        {
            int IdMax = getNewId(GetNewIDTable.Categorie);
            string sql = "Insert into Categories (Id_categorie, Nom_categorie) values (" + IdMax + ", '" + Textbox_categorie.Text.ToLower() + "');";
            addToDB(sql);
            initCategorieListe(); // raffraichi la liste de préremplissage du programme en ajoutant la nouvelle unité   
        }

        private void addSousCategorie()
        {
            int idCategorie = getItemID(GetIDTable.Categorie, Textbox_categorie.Text.ToLower());
            int IdMax = getNewId(GetNewIDTable.SousCategorie);
            string sql = "Insert into Sous_categories (Id_sous_categorie, Nom_sous_categorie, Id_categorie_fk) values (" + IdMax + ", '" + Textbox_sous_categorie.Text.ToLower() + "', " + idCategorie + ");";
            addToDB(sql);
            // Pas besoin de réinit la textbox de la sous cat car elle sera désactivée une fois l'entrée insérée et réinitialisée dès que la textbox catégorie sera éditée
        }

        private void addProduit()
        {
            int idSousCategorie = getItemID(GetIDTable.SousCategorie, Textbox_sous_categorie.Text.ToLower());
            int idUnit = getItemID(GetIDTable.Unit, Textbox_UniteProduit.Text.ToLower());
            int quantite = Convert.ToInt32(Textbox_QuantiteInitial.Text);
            int IdMax = getNewId(GetNewIDTable.Produit);
            string sql = "Insert into Produits (Id_produit, Nom_produit, Id_sous_categorie_fk, Id_unite_fk, Quantite_initial_produit) values (" + IdMax + ", '" + Textbox_nom.Text.ToLower() + "', " + idSousCategorie + ", " + idUnit + ", " + quantite + ");" ;
            addToDB(sql);
            //rechercher l'id de la cat + de la sous cat + de l'unite avant de faire l'insert.
        }

        private void addToDB(string sql)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.Dispose();
            cnn.Close();
        }

        private int getNewId(GetNewIDTable table)
        {
            String sql, Output = "";
            String NomTable = "", NomID = "";
            switch(table)
            {
                case GetNewIDTable.Categorie:
                    NomTable = "Categories";
                    NomID = "Id_categorie";
                    break;
                case GetNewIDTable.Produit:
                    NomTable = "Produits";
                    NomID = "Id_produit";
                    break;
                case GetNewIDTable.SousCategorie:
                    NomTable = "Sous_categories";
                    NomID = "Id_sous_categorie";
                    break;
                case GetNewIDTable.Unit:
                    NomTable = "Unite_mesure";
                    NomID = "Id_unite";
                    break;
            }
            sql = "Select Max(" + NomID + ") from " + NomTable + ";";
            Output = getFromDB(sql);
            int IdMax = 0;
            if (Output != "")
            {
                IdMax = Convert.ToInt32(Output) + 1;
            }
            return IdMax;
        }

        private int getItemID(GetIDTable table, string itemName)
        {
            String sql, Output = "";
            string unitName = Textbox_UniteProduit.Text.ToLower();
            string ChampTable = "";
            string ChampID = ""; 
            string ChampNom = "";
            switch(table)
            {
                case GetIDTable.Categorie:
                    ChampTable = "Categories";
                    ChampID = "Id_categorie";
                    ChampNom = "Nom_categorie";
                    break;
                case GetIDTable.SousCategorie:
                    ChampTable = "Sous_categories";
                    ChampID = "Id_sous_categorie";
                    ChampNom = "Nom_sous_categorie";
                    break;
                case GetIDTable.Unit:
                    ChampTable = "Unite_mesure";
                    ChampID = "Id_unite";
                    ChampNom = "Nom_unite";
                    break;
            }
            sql = "Select "+ ChampID +" from "+ ChampTable +" where "+ ChampNom +"='" + itemName + "';";
            Output = getFromDB(sql);
            int itemId = Convert.ToInt32(Output);
            return itemId;
        }

        private string getFromDB(string sql)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string Output = "";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0).ToString();
            }
            dataReader.Close();
            cnn.Close();
            return Output;
        }

        private void Textbox_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Mecanisme empêchant les caractères comme l'apostrophe simple ou double ainsi que les ; faisant planté MySQL
            char apostropheSimple = '\'';
            char apostropheDouble = '"';
            char pointVirgule = ';';
            char crochetOuvrant = '[';
            char crochetFermant = ']'; // Les crochets ouvrants et fermants sont utilisé pour obtenir l'index d'un item lors du retrait d'un élément du stock donc ils sont exclus pour évité de faire planter le programme
            if (apostropheSimple.Equals(e.KeyChar)||apostropheDouble.Equals(e.KeyChar) || pointVirgule.Equals(e.KeyChar) || crochetFermant.Equals(e.KeyChar) || crochetOuvrant.Equals(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
