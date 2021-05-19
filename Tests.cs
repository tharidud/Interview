// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tests.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Tests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Interview
{
    using System.Collections.Generic;

    using NUnit.Framework;

    /// <summary>
    /// The tests.
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// The all returns ienumberable correct type.
        /// </summary>
        [Test]
        public void All_Returns_IEnumberable_CorrectType()
        {
            // arrange
            var entities = new List<Storeable>();
            var repository = new Repository<Storeable>(entities);

            // act
            var expected = repository.All();

            // assert
            Assert.IsInstanceOf<IEnumerable<Storeable>>(expected);
        }

        /// <summary>
        /// The save_ add new item.
        /// </summary>
        [Test]
        public void Save_AddNewItem()
        {
            // arrange
            var entities = new List<Storeable>();
            var repository = new Repository<Storeable>(entities);
            var newItem = new Storeable { Id = 1, Name = "NewItem" };

            // act
            repository.Save(newItem);

            // assert
            Assert.IsTrue(entities.Contains(newItem));
        }

        /// <summary>
        /// The delete_ an_ existing_ item.
        /// </summary>
        [Test]
        public void Delete_An_Existing_Item()
        {
            // arrange
            var entities = new List<Storeable>() { new Storeable { Id = 1, Name = "ExistingItem" } };
            var repository = new Repository<Storeable>(entities);

            // act
            repository.Delete(1);

            // assert
            Assert.IsFalse(entities.Count == 1);
        }

        /// <summary>
        /// The find_ by_ id_ returns_ correct_ item.
        /// </summary>
        [Test]
        public void Find_By_Id_Returns_Correct_Item()
        {
            // arrange
            var itemList = new List<Storeable> { new Storeable { Id = 1, Name = "ItemOne" }, new Storeable { Id = 2, Name = "ItemTwo" }, new Storeable { Id = 3, Name = "ItemThree" } };
            var repository = new Repository<Storeable>(itemList);
            
            // act
            var expected = repository.FindById(2);

            // assert
            Assert.AreEqual(itemList[1], expected);
        }
    }
}