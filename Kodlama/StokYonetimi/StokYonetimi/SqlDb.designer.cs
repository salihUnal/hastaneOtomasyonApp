﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5416
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokYonetimi
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="Cht_StokTakip")]
	public partial class SqlDb : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMusteriAdresleri(MusteriAdresleri instance);
    partial void UpdateMusteriAdresleri(MusteriAdresleri instance);
    partial void DeleteMusteriAdresleri(MusteriAdresleri instance);
    partial void InsertStokFiyatlari(StokFiyatlari instance);
    partial void UpdateStokFiyatlari(StokFiyatlari instance);
    partial void DeleteStokFiyatlari(StokFiyatlari instance);
    partial void InsertStokGC(StokGC instance);
    partial void UpdateStokGC(StokGC instance);
    partial void DeleteStokGC(StokGC instance);
    partial void InsertStoklar(Stoklar instance);
    partial void UpdateStoklar(Stoklar instance);
    partial void DeleteStoklar(Stoklar instance);
    partial void InsertMusteriler(Musteriler instance);
    partial void UpdateMusteriler(Musteriler instance);
    partial void DeleteMusteriler(Musteriler instance);
    #endregion
		
		public SqlDb() : 
				base(global::StokYonetimi.Properties.Settings.Default.Cht_StokTakipConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SqlDb(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SqlDb(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SqlDb(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SqlDb(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MusteriAdresleri> MusteriAdresleris
		{
			get
			{
				return this.GetTable<MusteriAdresleri>();
			}
		}
		
		public System.Data.Linq.Table<StokFiyatlari> StokFiyatlaris
		{
			get
			{
				return this.GetTable<StokFiyatlari>();
			}
		}
		
		public System.Data.Linq.Table<StokGC> StokGCs
		{
			get
			{
				return this.GetTable<StokGC>();
			}
		}
		
		public System.Data.Linq.Table<Stoklar> Stoklars
		{
			get
			{
				return this.GetTable<Stoklar>();
			}
		}
		
		public System.Data.Linq.Table<Musteriler> Musterilers
		{
			get
			{
				return this.GetTable<Musteriler>();
			}
		}
	}
	
	[Table(Name="dbo.MusteriAdresleri")]
	public partial class MusteriAdresleri : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MusteriAdresKayitNo;
		
		private string _MusteriAdresMusteriKodu;
		
		private System.Nullable<int> _MusteriAdresNo;
		
		private string _MusteriAdresCadde;
		
		private string _MusteriAdresSokak;
		
		private string _MusteriAdresIlce;
		
		private string _MusteriAdresIl;
		
		private string _MusteriAdresTelefon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMusteriAdresKayitNoChanging(int value);
    partial void OnMusteriAdresKayitNoChanged();
    partial void OnMusteriAdresMusteriKoduChanging(string value);
    partial void OnMusteriAdresMusteriKoduChanged();
    partial void OnMusteriAdresNoChanging(System.Nullable<int> value);
    partial void OnMusteriAdresNoChanged();
    partial void OnMusteriAdresCaddeChanging(string value);
    partial void OnMusteriAdresCaddeChanged();
    partial void OnMusteriAdresSokakChanging(string value);
    partial void OnMusteriAdresSokakChanged();
    partial void OnMusteriAdresIlceChanging(string value);
    partial void OnMusteriAdresIlceChanged();
    partial void OnMusteriAdresIlChanging(string value);
    partial void OnMusteriAdresIlChanged();
    partial void OnMusteriAdresTelefonChanging(string value);
    partial void OnMusteriAdresTelefonChanged();
    #endregion
		
		public MusteriAdresleri()
		{
			OnCreated();
		}
		
		[Column(Storage="_MusteriAdresKayitNo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, IsVersion=true)]
		public int MusteriAdresKayitNo
		{
			get
			{
				return this._MusteriAdresKayitNo;
			}
			set
			{
				if ((this._MusteriAdresKayitNo != value))
				{
					this.OnMusteriAdresKayitNoChanging(value);
					this.SendPropertyChanging();
					this._MusteriAdresKayitNo = value;
					this.SendPropertyChanged("MusteriAdresKayitNo");
					this.OnMusteriAdresKayitNoChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriAdresMusteriKodu", DbType="VarChar(50)")]
		public string MusteriAdresMusteriKodu
		{
			get
			{
				return this._MusteriAdresMusteriKodu;
			}
			set
			{
				if ((this._MusteriAdresMusteriKodu != value))
				{
					this.OnMusteriAdresMusteriKoduChanging(value);
					this.SendPropertyChanging();
					this._MusteriAdresMusteriKodu = value;
					this.SendPropertyChanged("MusteriAdresMusteriKodu");
					this.OnMusteriAdresMusteriKoduChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriAdresNo", DbType="Int")]
		public System.Nullable<int> MusteriAdresNo
		{
			get
			{
				return this._MusteriAdresNo;
			}
			set
			{
				if ((this._MusteriAdresNo != value))
				{
					this.OnMusteriAdresNoChanging(value);
					this.SendPropertyChanging();
					this._MusteriAdresNo = value;
					this.SendPropertyChanged("MusteriAdresNo");
					this.OnMusteriAdresNoChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriAdresCadde", DbType="VarChar(50)")]
		public string MusteriAdresCadde
		{
			get
			{
				return this._MusteriAdresCadde;
			}
			set
			{
				if ((this._MusteriAdresCadde != value))
				{
					this.OnMusteriAdresCaddeChanging(value);
					this.SendPropertyChanging();
					this._MusteriAdresCadde = value;
					this.SendPropertyChanged("MusteriAdresCadde");
					this.OnMusteriAdresCaddeChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriAdresSokak", DbType="VarChar(50)")]
		public string MusteriAdresSokak
		{
			get
			{
				return this._MusteriAdresSokak;
			}
			set
			{
				if ((this._MusteriAdresSokak != value))
				{
					this.OnMusteriAdresSokakChanging(value);
					this.SendPropertyChanging();
					this._MusteriAdresSokak = value;
					this.SendPropertyChanged("MusteriAdresSokak");
					this.OnMusteriAdresSokakChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriAdresIlce", DbType="VarChar(50)")]
		public string MusteriAdresIlce
		{
			get
			{
				return this._MusteriAdresIlce;
			}
			set
			{
				if ((this._MusteriAdresIlce != value))
				{
					this.OnMusteriAdresIlceChanging(value);
					this.SendPropertyChanging();
					this._MusteriAdresIlce = value;
					this.SendPropertyChanged("MusteriAdresIlce");
					this.OnMusteriAdresIlceChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriAdresIl", DbType="VarChar(50)")]
		public string MusteriAdresIl
		{
			get
			{
				return this._MusteriAdresIl;
			}
			set
			{
				if ((this._MusteriAdresIl != value))
				{
					this.OnMusteriAdresIlChanging(value);
					this.SendPropertyChanging();
					this._MusteriAdresIl = value;
					this.SendPropertyChanged("MusteriAdresIl");
					this.OnMusteriAdresIlChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriAdresTelefon", DbType="VarChar(50)")]
		public string MusteriAdresTelefon
		{
			get
			{
				return this._MusteriAdresTelefon;
			}
			set
			{
				if ((this._MusteriAdresTelefon != value))
				{
					this.OnMusteriAdresTelefonChanging(value);
					this.SendPropertyChanging();
					this._MusteriAdresTelefon = value;
					this.SendPropertyChanged("MusteriAdresTelefon");
					this.OnMusteriAdresTelefonChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dbo.StokFiyatlari")]
	public partial class StokFiyatlari : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StokFiyatKayitNo;
		
		private string _StokFiyatStokKodu;
		
		private System.Nullable<int> _StokFiyatNo;
		
		private System.Nullable<double> _StokFiyatFiyati;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStokFiyatKayitNoChanging(int value);
    partial void OnStokFiyatKayitNoChanged();
    partial void OnStokFiyatStokKoduChanging(string value);
    partial void OnStokFiyatStokKoduChanged();
    partial void OnStokFiyatNoChanging(System.Nullable<int> value);
    partial void OnStokFiyatNoChanged();
    partial void OnStokFiyatFiyatiChanging(System.Nullable<double> value);
    partial void OnStokFiyatFiyatiChanged();
    #endregion
		
		public StokFiyatlari()
		{
			OnCreated();
		}
		
		[Column(Storage="_StokFiyatKayitNo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, IsVersion=true)]
		public int StokFiyatKayitNo
		{
			get
			{
				return this._StokFiyatKayitNo;
			}
			set
			{
				if ((this._StokFiyatKayitNo != value))
				{
					this.OnStokFiyatKayitNoChanging(value);
					this.SendPropertyChanging();
					this._StokFiyatKayitNo = value;
					this.SendPropertyChanged("StokFiyatKayitNo");
					this.OnStokFiyatKayitNoChanged();
				}
			}
		}
		
		[Column(Storage="_StokFiyatStokKodu", DbType="VarChar(50)")]
		public string StokFiyatStokKodu
		{
			get
			{
				return this._StokFiyatStokKodu;
			}
			set
			{
				if ((this._StokFiyatStokKodu != value))
				{
					this.OnStokFiyatStokKoduChanging(value);
					this.SendPropertyChanging();
					this._StokFiyatStokKodu = value;
					this.SendPropertyChanged("StokFiyatStokKodu");
					this.OnStokFiyatStokKoduChanged();
				}
			}
		}
		
		[Column(Storage="_StokFiyatNo", DbType="Int")]
		public System.Nullable<int> StokFiyatNo
		{
			get
			{
				return this._StokFiyatNo;
			}
			set
			{
				if ((this._StokFiyatNo != value))
				{
					this.OnStokFiyatNoChanging(value);
					this.SendPropertyChanging();
					this._StokFiyatNo = value;
					this.SendPropertyChanged("StokFiyatNo");
					this.OnStokFiyatNoChanged();
				}
			}
		}
		
		[Column(Storage="_StokFiyatFiyati", DbType="Float")]
		public System.Nullable<double> StokFiyatFiyati
		{
			get
			{
				return this._StokFiyatFiyati;
			}
			set
			{
				if ((this._StokFiyatFiyati != value))
				{
					this.OnStokFiyatFiyatiChanging(value);
					this.SendPropertyChanging();
					this._StokFiyatFiyati = value;
					this.SendPropertyChanged("StokFiyatFiyati");
					this.OnStokFiyatFiyatiChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dbo.StokGC")]
	public partial class StokGC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StokGCKayitNo;
		
		private System.Nullable<int> _StokGCTipi;
		
		private System.Nullable<System.DateTime> _StokGCTarih;
		
		private System.Nullable<int> _StokGCEvrakNo;
		
		private System.Nullable<int> _StokGCSatirNo;
		
		private string _StokGCMusteriKodu;
		
		private System.Nullable<int> _StokGCMusteriAdresNo;
		
		private string _StokGCStokKodu;
		
		private System.Nullable<int> _StokGCStokFiyatNo;
		
		private System.Nullable<double> _StokGCStokFiyati;
		
		private System.Nullable<double> _StokGCStokMiktari;
		
		private System.Nullable<double> _StokGCStokVergi;
		
		private System.Nullable<double> _StokGCStokTutar;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStokGCKayitNoChanging(int value);
    partial void OnStokGCKayitNoChanged();
    partial void OnStokGCTipiChanging(System.Nullable<int> value);
    partial void OnStokGCTipiChanged();
    partial void OnStokGCTarihChanging(System.Nullable<System.DateTime> value);
    partial void OnStokGCTarihChanged();
    partial void OnStokGCEvrakNoChanging(System.Nullable<int> value);
    partial void OnStokGCEvrakNoChanged();
    partial void OnStokGCSatirNoChanging(System.Nullable<int> value);
    partial void OnStokGCSatirNoChanged();
    partial void OnStokGCMusteriKoduChanging(string value);
    partial void OnStokGCMusteriKoduChanged();
    partial void OnStokGCMusteriAdresNoChanging(System.Nullable<int> value);
    partial void OnStokGCMusteriAdresNoChanged();
    partial void OnStokGCStokKoduChanging(string value);
    partial void OnStokGCStokKoduChanged();
    partial void OnStokGCStokFiyatNoChanging(System.Nullable<int> value);
    partial void OnStokGCStokFiyatNoChanged();
    partial void OnStokGCStokFiyatiChanging(System.Nullable<double> value);
    partial void OnStokGCStokFiyatiChanged();
    partial void OnStokGCStokMiktariChanging(System.Nullable<double> value);
    partial void OnStokGCStokMiktariChanged();
    partial void OnStokGCStokVergiChanging(System.Nullable<double> value);
    partial void OnStokGCStokVergiChanged();
    partial void OnStokGCStokTutarChanging(System.Nullable<double> value);
    partial void OnStokGCStokTutarChanged();
    #endregion
		
		public StokGC()
		{
			OnCreated();
		}
		
		[Column(Storage="_StokGCKayitNo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, IsVersion=true)]
		public int StokGCKayitNo
		{
			get
			{
				return this._StokGCKayitNo;
			}
			set
			{
				if ((this._StokGCKayitNo != value))
				{
					this.OnStokGCKayitNoChanging(value);
					this.SendPropertyChanging();
					this._StokGCKayitNo = value;
					this.SendPropertyChanged("StokGCKayitNo");
					this.OnStokGCKayitNoChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCTipi", DbType="Int")]
		public System.Nullable<int> StokGCTipi
		{
			get
			{
				return this._StokGCTipi;
			}
			set
			{
				if ((this._StokGCTipi != value))
				{
					this.OnStokGCTipiChanging(value);
					this.SendPropertyChanging();
					this._StokGCTipi = value;
					this.SendPropertyChanged("StokGCTipi");
					this.OnStokGCTipiChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCTarih", DbType="DateTime")]
		public System.Nullable<System.DateTime> StokGCTarih
		{
			get
			{
				return this._StokGCTarih;
			}
			set
			{
				if ((this._StokGCTarih != value))
				{
					this.OnStokGCTarihChanging(value);
					this.SendPropertyChanging();
					this._StokGCTarih = value;
					this.SendPropertyChanged("StokGCTarih");
					this.OnStokGCTarihChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCEvrakNo", DbType="Int")]
		public System.Nullable<int> StokGCEvrakNo
		{
			get
			{
				return this._StokGCEvrakNo;
			}
			set
			{
				if ((this._StokGCEvrakNo != value))
				{
					this.OnStokGCEvrakNoChanging(value);
					this.SendPropertyChanging();
					this._StokGCEvrakNo = value;
					this.SendPropertyChanged("StokGCEvrakNo");
					this.OnStokGCEvrakNoChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCSatirNo", DbType="Int")]
		public System.Nullable<int> StokGCSatirNo
		{
			get
			{
				return this._StokGCSatirNo;
			}
			set
			{
				if ((this._StokGCSatirNo != value))
				{
					this.OnStokGCSatirNoChanging(value);
					this.SendPropertyChanging();
					this._StokGCSatirNo = value;
					this.SendPropertyChanged("StokGCSatirNo");
					this.OnStokGCSatirNoChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCMusteriKodu", DbType="VarChar(50)")]
		public string StokGCMusteriKodu
		{
			get
			{
				return this._StokGCMusteriKodu;
			}
			set
			{
				if ((this._StokGCMusteriKodu != value))
				{
					this.OnStokGCMusteriKoduChanging(value);
					this.SendPropertyChanging();
					this._StokGCMusteriKodu = value;
					this.SendPropertyChanged("StokGCMusteriKodu");
					this.OnStokGCMusteriKoduChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCMusteriAdresNo", DbType="Int")]
		public System.Nullable<int> StokGCMusteriAdresNo
		{
			get
			{
				return this._StokGCMusteriAdresNo;
			}
			set
			{
				if ((this._StokGCMusteriAdresNo != value))
				{
					this.OnStokGCMusteriAdresNoChanging(value);
					this.SendPropertyChanging();
					this._StokGCMusteriAdresNo = value;
					this.SendPropertyChanged("StokGCMusteriAdresNo");
					this.OnStokGCMusteriAdresNoChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCStokKodu", DbType="VarChar(50)")]
		public string StokGCStokKodu
		{
			get
			{
				return this._StokGCStokKodu;
			}
			set
			{
				if ((this._StokGCStokKodu != value))
				{
					this.OnStokGCStokKoduChanging(value);
					this.SendPropertyChanging();
					this._StokGCStokKodu = value;
					this.SendPropertyChanged("StokGCStokKodu");
					this.OnStokGCStokKoduChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCStokFiyatNo", DbType="Int")]
		public System.Nullable<int> StokGCStokFiyatNo
		{
			get
			{
				return this._StokGCStokFiyatNo;
			}
			set
			{
				if ((this._StokGCStokFiyatNo != value))
				{
					this.OnStokGCStokFiyatNoChanging(value);
					this.SendPropertyChanging();
					this._StokGCStokFiyatNo = value;
					this.SendPropertyChanged("StokGCStokFiyatNo");
					this.OnStokGCStokFiyatNoChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCStokFiyati", DbType="Float")]
		public System.Nullable<double> StokGCStokFiyati
		{
			get
			{
				return this._StokGCStokFiyati;
			}
			set
			{
				if ((this._StokGCStokFiyati != value))
				{
					this.OnStokGCStokFiyatiChanging(value);
					this.SendPropertyChanging();
					this._StokGCStokFiyati = value;
					this.SendPropertyChanged("StokGCStokFiyati");
					this.OnStokGCStokFiyatiChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCStokMiktari", DbType="Float")]
		public System.Nullable<double> StokGCStokMiktari
		{
			get
			{
				return this._StokGCStokMiktari;
			}
			set
			{
				if ((this._StokGCStokMiktari != value))
				{
					this.OnStokGCStokMiktariChanging(value);
					this.SendPropertyChanging();
					this._StokGCStokMiktari = value;
					this.SendPropertyChanged("StokGCStokMiktari");
					this.OnStokGCStokMiktariChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCStokVergi", DbType="Float")]
		public System.Nullable<double> StokGCStokVergi
		{
			get
			{
				return this._StokGCStokVergi;
			}
			set
			{
				if ((this._StokGCStokVergi != value))
				{
					this.OnStokGCStokVergiChanging(value);
					this.SendPropertyChanging();
					this._StokGCStokVergi = value;
					this.SendPropertyChanged("StokGCStokVergi");
					this.OnStokGCStokVergiChanged();
				}
			}
		}
		
		[Column(Storage="_StokGCStokTutar", DbType="Float")]
		public System.Nullable<double> StokGCStokTutar
		{
			get
			{
				return this._StokGCStokTutar;
			}
			set
			{
				if ((this._StokGCStokTutar != value))
				{
					this.OnStokGCStokTutarChanging(value);
					this.SendPropertyChanging();
					this._StokGCStokTutar = value;
					this.SendPropertyChanged("StokGCStokTutar");
					this.OnStokGCStokTutarChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dbo.Stoklar")]
	public partial class Stoklar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StokKayitNo;
		
		private string _StokKodu;
		
		private string _StokAdi;
		
		private System.Nullable<double> _VergiOrani;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStokKayitNoChanging(int value);
    partial void OnStokKayitNoChanged();
    partial void OnStokKoduChanging(string value);
    partial void OnStokKoduChanged();
    partial void OnStokAdiChanging(string value);
    partial void OnStokAdiChanged();
    partial void OnVergiOraniChanging(System.Nullable<double> value);
    partial void OnVergiOraniChanged();
    #endregion
		
		public Stoklar()
		{
			OnCreated();
		}
		
		[Column(Storage="_StokKayitNo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, IsVersion=true)]
		public int StokKayitNo
		{
			get
			{
				return this._StokKayitNo;
			}
			set
			{
				if ((this._StokKayitNo != value))
				{
					this.OnStokKayitNoChanging(value);
					this.SendPropertyChanging();
					this._StokKayitNo = value;
					this.SendPropertyChanged("StokKayitNo");
					this.OnStokKayitNoChanged();
				}
			}
		}
		
		[Column(Storage="_StokKodu", DbType="VarChar(50)")]
		public string StokKodu
		{
			get
			{
				return this._StokKodu;
			}
			set
			{
				if ((this._StokKodu != value))
				{
					this.OnStokKoduChanging(value);
					this.SendPropertyChanging();
					this._StokKodu = value;
					this.SendPropertyChanged("StokKodu");
					this.OnStokKoduChanged();
				}
			}
		}
		
		[Column(Storage="_StokAdi", DbType="VarChar(50)")]
		public string StokAdi
		{
			get
			{
				return this._StokAdi;
			}
			set
			{
				if ((this._StokAdi != value))
				{
					this.OnStokAdiChanging(value);
					this.SendPropertyChanging();
					this._StokAdi = value;
					this.SendPropertyChanged("StokAdi");
					this.OnStokAdiChanged();
				}
			}
		}
		
		[Column(Storage="_VergiOrani", DbType="Float")]
		public System.Nullable<double> VergiOrani
		{
			get
			{
				return this._VergiOrani;
			}
			set
			{
				if ((this._VergiOrani != value))
				{
					this.OnVergiOraniChanging(value);
					this.SendPropertyChanging();
					this._VergiOrani = value;
					this.SendPropertyChanged("VergiOrani");
					this.OnVergiOraniChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dbo.Musteriler")]
	public partial class Musteriler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MusteriKayitNo;
		
		private string _MusteriKodu;
		
		private string _MusteriUnvani;
		
		private string _MusteriYetkilisi;
		
		private string _MusteriVergiDairesi;
		
		private string _MusteriVergiNo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMusteriKayitNoChanging(int value);
    partial void OnMusteriKayitNoChanged();
    partial void OnMusteriKoduChanging(string value);
    partial void OnMusteriKoduChanged();
    partial void OnMusteriUnvaniChanging(string value);
    partial void OnMusteriUnvaniChanged();
    partial void OnMusteriYetkilisiChanging(string value);
    partial void OnMusteriYetkilisiChanged();
    partial void OnMusteriVergiDairesiChanging(string value);
    partial void OnMusteriVergiDairesiChanged();
    partial void OnMusteriVergiNoChanging(string value);
    partial void OnMusteriVergiNoChanged();
    #endregion
		
		public Musteriler()
		{
			OnCreated();
		}
		
		[Column(Storage="_MusteriKayitNo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, IsVersion=true)]
		public int MusteriKayitNo
		{
			get
			{
				return this._MusteriKayitNo;
			}
			set
			{
				if ((this._MusteriKayitNo != value))
				{
					this.OnMusteriKayitNoChanging(value);
					this.SendPropertyChanging();
					this._MusteriKayitNo = value;
					this.SendPropertyChanged("MusteriKayitNo");
					this.OnMusteriKayitNoChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriKodu", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MusteriKodu
		{
			get
			{
				return this._MusteriKodu;
			}
			set
			{
				if ((this._MusteriKodu != value))
				{
					this.OnMusteriKoduChanging(value);
					this.SendPropertyChanging();
					this._MusteriKodu = value;
					this.SendPropertyChanged("MusteriKodu");
					this.OnMusteriKoduChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriUnvani", DbType="VarChar(50)")]
		public string MusteriUnvani
		{
			get
			{
				return this._MusteriUnvani;
			}
			set
			{
				if ((this._MusteriUnvani != value))
				{
					this.OnMusteriUnvaniChanging(value);
					this.SendPropertyChanging();
					this._MusteriUnvani = value;
					this.SendPropertyChanged("MusteriUnvani");
					this.OnMusteriUnvaniChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriYetkilisi", DbType="VarChar(50)")]
		public string MusteriYetkilisi
		{
			get
			{
				return this._MusteriYetkilisi;
			}
			set
			{
				if ((this._MusteriYetkilisi != value))
				{
					this.OnMusteriYetkilisiChanging(value);
					this.SendPropertyChanging();
					this._MusteriYetkilisi = value;
					this.SendPropertyChanged("MusteriYetkilisi");
					this.OnMusteriYetkilisiChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriVergiDairesi", DbType="VarChar(50)")]
		public string MusteriVergiDairesi
		{
			get
			{
				return this._MusteriVergiDairesi;
			}
			set
			{
				if ((this._MusteriVergiDairesi != value))
				{
					this.OnMusteriVergiDairesiChanging(value);
					this.SendPropertyChanging();
					this._MusteriVergiDairesi = value;
					this.SendPropertyChanged("MusteriVergiDairesi");
					this.OnMusteriVergiDairesiChanged();
				}
			}
		}
		
		[Column(Storage="_MusteriVergiNo", DbType="VarChar(50)")]
		public string MusteriVergiNo
		{
			get
			{
				return this._MusteriVergiNo;
			}
			set
			{
				if ((this._MusteriVergiNo != value))
				{
					this.OnMusteriVergiNoChanging(value);
					this.SendPropertyChanging();
					this._MusteriVergiNo = value;
					this.SendPropertyChanged("MusteriVergiNo");
					this.OnMusteriVergiNoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
