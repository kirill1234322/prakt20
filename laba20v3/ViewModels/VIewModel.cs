using laba20v3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace laba20v3.ViewModels
{
    public class VIewModel: INotifyPropertyChanged
    {
        laba19_20Entities laba1920 = new laba19_20Entities();
        RCommand RCom { get; set; }
        RCommand RCom1 { get; set; }
        public VIewModel()
        {
            
        }

        public ObservableCollection<Postav> postlist { get; set; } = new ObservableCollection<Postav>();
        public Postav SelectedP { get; set; }
        public ObservableCollection<Postav> Postavs
        {
            get { return postlist; }
            set
            {
                postlist = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<nom> nomlist { get; set; } = new ObservableCollection<nom>();
        public ObservableCollection<nom> Noms
        {
            get { return nomlist; }
            set
            {
                nomlist = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<nom> _nomlist { get; set; } = new ObservableCollection<nom>();
        public ObservableCollection<nom> _Noms
        {
            get { return _nomlist; }
            set
            {
                _nomlist = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<tov> tovlist { get; set; } = new ObservableCollection<tov>();
        public ObservableCollection<tov> Tovs
        {
            get { return tovlist; }
            set
            {
                tovlist = value;
                OnPropertyChanged();
            }
        }


        public void OutputPostav()
        {
            var table = from item in laba1920.Postav select item;
            table.Load();
            postlist = laba1920.Postav.Local;
        }
        public void OutputNom()
        {
            var table = from item in laba1920.nom select item;
            table.Load();
            nomlist = laba1920.nom.Local;
        }
        public void OutputTov()
        {

            var table = from item in laba1920.tov select item;
            table.Load();
            tovlist = laba1920.tov.Local;
        }


       

        public RCommand AddCommandPostav
        {
            get
            {
                return RCom ??
                  (RCom = new RCommand((o) =>
                  {

                      AddPostav addPostav = new AddPostav();
                      addPostav.ShowDialog();

                  }));
            }
        }
        public RCommand AddCommandNomen
        {
            get
            {
                return RCom1 ??
                  (RCom1 = new RCommand((o) =>
                  {

                      AddNomen addPostav = new AddNomen();
                      addPostav.ShowDialog();

                  }));
            }
        }
        public RCommand RemoveCommandPostav
        {
            get
            {
                return RCom1 ??
                  (RCom1 = new RCommand((o) =>
                  {

                      
                      

                  }));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
