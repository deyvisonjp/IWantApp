﻿using Flunt.Validations;

namespace IWantApp.Domain.Products
{
    public class Category : Entity
    {
        public string Name { get; private set; }
        public bool Active { get; private set; }

        public Category(string name, string createdBy, string editedBy)
        {
            Name = name;
            Active = true;
            CreatedBy = createdBy;
            EditedBy = editedBy;
            CreatedOn = DateTime.Now;
            EditeOn = DateTime.Now;

            Validate();

        }
        public void EditInfo(string name, bool active)
        {
            Active = active;
            Name = name;

            Validate();
        }

        private void Validate()
        {
            var contract = new Contract<Category>()
                            .IsNotNullOrEmpty(Name, "Name", "Nome é obrigatório.")
                            .IsGreaterOrEqualsThan(Name, 3, "Name") //Ou igual ou maior que 3 caracteres
                            .IsNotNullOrEmpty(CreatedBy, "CreatedBy")
                            .IsNotNullOrEmpty(EditedBy, "EditedBy");
            AddNotifications(contract);
        }


    }
}
