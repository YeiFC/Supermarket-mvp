using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class ProvidersPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providerBindingSource;
        private IEnumerable<ProviderModel> providerList;

        public ProvidersPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProvider;
            this.view.AddNewEvent += AddNewProvider;
            this.view.EditEvent += LoadSelectProviderToEdit;
            this.view.DeleteEvent += DeleteSelectedProvider;
            this.view.SaveEvent += SaveProvider;
            this.view.CancelEvent += CancelAction;

            this.view.SetProviderListBindingSource(providerBindingSource);

            LoadAllProviderList();

            this.view.Show();

        }

        private void LoadAllProviderList()
        {
            providerList = repository.GetAll();
            providerBindingSource.DataSource = providerList;
        }
        private void SearchProvider(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providerList = repository.GetByValues(this.view.SearchValue);
            }
            else
            {
                providerList = repository.GetAll();
            }
            providerBindingSource.DataSource = providerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProvider(object? sender, EventArgs e)
        {
            var provider = new ProviderModel();
            provider.ProviderId = Convert.ToInt32(view.ProviderId);
            provider.ProviderName = view.ProviderName;
            provider.ProviderContactName = view.ProviderContactName;
            provider.ProviderContactPhone = view.ProviderContactPhone;
            provider.ProviderEmail = view.ProviderEmail;

            try
            {
                // Validación de modelo
                // new Common.ModelDataValidation().Validate(provider);
                if (view.IsEdit)
                {
                    repository.Edit(provider);
                    view.Message = "Provider edited successfully";
                }
                else
                {
                    repository.Add(provider);
                    view.Message = "Provider added successfully";
                }
                view.IsSuccessful = true;
                LoadAllProviderList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProviderId = "0";
            view.ProviderName = "";
            view.ProviderContactName = "";
            view.ProviderContactPhone = "";
            view.ProviderEmail = "";
        }

        private void LoadSelectProviderToEdit(object? sender, EventArgs e)
        {
            var provider = (ProviderModel)providerBindingSource.Current;

            view.ProviderId = provider.ProviderId.ToString();
            view.ProviderName = provider.ProviderName;
            view.ProviderContactName = provider.ProviderContactName;
            view.ProviderContactPhone = provider.ProviderContactPhone;
            view.ProviderEmail = provider.ProviderEmail;

            view.IsEdit = false;
        }

        private void DeleteSelectedProvider(object? sender, EventArgs e)
        {
            try
            {
                var provider = (ProviderModel)providerBindingSource.Current;

                repository.Delete(provider.ProviderId);
                view.IsSuccessful = true;
                view.Message = "Provider deleted successfully";
                LoadAllProviderList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete provider";
            }
        }

        private void AddNewProvider(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }


    }
}
