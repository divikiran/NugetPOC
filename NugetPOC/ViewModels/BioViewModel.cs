using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using NugetPOC.Helpers;
using NugetPOC.Models;

namespace NugetPOC.ViewModels
{
    public class BioViewModel : FreshBasePageModel
    {
        public ObservableCollection<User> Users { get; set; }
        public User User { get; set; } = new User();


        public ICommand SubmitCommand { get; set; }

        public BioViewModel()
        {
            if (Users == null)
            {
                Users = new ObservableCollection<User>();
            }

            SubmitCommand = new FreshAwaitCommand(async (obj) =>
            {
                TaskCompletionSource<bool> a = obj;
                await SubmitAction(obj);
            });

        }

        private async Task SubmitAction(TaskCompletionSource<bool> obj)
        {
            try
            {
                await Task.Delay(2000);

                var page = this.CurrentPage;

                if (ValidationHelper.IsFormValid(User, page))
                {
                    Users.Add(User);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                obj.SetResult(true);
            }

        }
    }
}
