using System;
using System.Collections.Generic;
using ChallengeApi.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using ChallengeApi.Utils;

namespace ChallengeApi.DataStore
{
    public class ColorDb : IColorDb
    {
        private readonly List<string> _colorList = new List<string>();

        public ColorDb()
        {
            LoadList();
        }

        public void LoadList()
        {
            _colorList.Add("Blue");
            _colorList.Add("Red");
            _colorList.Add("Purple");
            _colorList.Add("Green");
            _colorList.Add("Indigo");
            _colorList.Add("Yellow");
            _colorList.Add("White");
            _colorList.Add("Black");
        }

        public string SelectRandomColor()
        {          
            return _colorList[RandomNumberHelper.GenerateRandomNumber(_colorList.Count)];
        }
    }
}
