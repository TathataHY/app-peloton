using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.ViewModels
{
    public class ChallengesViewModel : BaseViewModel
    {
        private int selectedCategoryIndex;
        public int SelectedCategoryIndex { get => selectedCategoryIndex; set => SetProperty(ref selectedCategoryIndex, value); }

        public ChallengesViewModel()
        {
            SelectCategoryCommand = new Command<string>(OnSelectCategory);
        }

        void OnSelectCategory(string index)
        {
            if (int.TryParse(index, out int i))
            {
                SelectedCategoryIndex = i;
            }
        }
        public Command<string> SelectCategoryCommand { get; }
    }
}
