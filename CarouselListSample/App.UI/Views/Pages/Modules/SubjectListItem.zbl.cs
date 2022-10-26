using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Modules
{
    partial class SubjectListItem
    {
        private WordInfo _wordInfo;
        public WordInfo WordInfo
        {
            get
            {
                return _wordInfo;
            }
            set
            {
                _wordInfo = value;
                WordInfoChanged();
            }
        }

        private void WordInfoChanged()
        {
            WordTitle.Text = WordInfo.Text;
            WordRank.Text = WordInfo.OtherForms;
            WordSub.Text = WordInfo.Meaning;
        }
    }
}
