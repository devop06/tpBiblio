using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using BiblioAsp.Models;
using BiblioAsp.Models.Interface;

namespace BiblioAspTest
{
    [TestClass]
    public class UnitTest1
    {
        private IDal dal;
            [TestInitialize]
            public void Init_AvantChaqueTest()
            {
                IDatabaseInitializer<BiblioContext> init = new DropCreateDatabaseAlways<BiblioContext>();
                Database.SetInitializer(init);
                init.InitializeDatabase(new BiblioContext());
                this.dal = new Dal();
            }

            [TestMethod]
            public void CreerAuteur_AvecNouveauAuteur_RetrouverAuteur()
            {
                this.dal.AjouterAuteur("Victor Hugo");
                
                this.dal.ObtenirLesAuteurs();
            Assert.AreEqual("Victor Hugo", this.dal.ObtenirLesAuteurs()[0].Nom);
            }

        [TestCleanup]
        public void ApresChaqueTest()
        {
            dal.Dispose();
        }

    }
}
