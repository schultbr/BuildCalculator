﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace BuildCalculatorModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DOTA2BuildCalculatorEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DOTA2BuildCalculatorEntities object using the connection string found in the 'DOTA2BuildCalculatorEntities' section of the application configuration file.
        /// </summary>
        public DOTA2BuildCalculatorEntities() : base("name=DOTA2BuildCalculatorEntities", "DOTA2BuildCalculatorEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DOTA2BuildCalculatorEntities object.
        /// </summary>
        public DOTA2BuildCalculatorEntities(string connectionString) : base(connectionString, "DOTA2BuildCalculatorEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DOTA2BuildCalculatorEntities object.
        /// </summary>
        public DOTA2BuildCalculatorEntities(EntityConnection connection) : base(connection, "DOTA2BuildCalculatorEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Champion> Champions
        {
            get
            {
                if ((_Champions == null))
                {
                    _Champions = base.CreateObjectSet<Champion>("Champions");
                }
                return _Champions;
            }
        }
        private ObjectSet<Champion> _Champions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Item> Items
        {
            get
            {
                if ((_Items == null))
                {
                    _Items = base.CreateObjectSet<Item>("Items");
                }
                return _Items;
            }
        }
        private ObjectSet<Item> _Items;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Champions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToChampions(Champion champion)
        {
            base.AddObject("Champions", champion);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Items EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToItems(Item item)
        {
            base.AddObject("Items", item);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DOTA2BuildCalculatorModel", Name="Champion")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Champion : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Champion object.
        /// </summary>
        /// <param name="championID">Initial value of the ChampionID property.</param>
        /// <param name="championName">Initial value of the ChampionName property.</param>
        /// <param name="initialStr">Initial value of the initialStr property.</param>
        /// <param name="initialAgi">Initial value of the initialAgi property.</param>
        /// <param name="initialint">Initial value of the initialint property.</param>
        /// <param name="strGrowth">Initial value of the strGrowth property.</param>
        /// <param name="agiGrowth">Initial value of the agiGrowth property.</param>
        /// <param name="intGrowth">Initial value of the intGrowth property.</param>
        /// <param name="movSpeed">Initial value of the movSpeed property.</param>
        /// <param name="armor">Initial value of the armor property.</param>
        /// <param name="range">Initial value of the range property.</param>
        public static Champion CreateChampion(global::System.Int32 championID, global::System.String championName, global::System.Double initialStr, global::System.Double initialAgi, global::System.Double initialint, global::System.Double strGrowth, global::System.Double agiGrowth, global::System.Double intGrowth, global::System.Double movSpeed, global::System.Double armor, global::System.Double range)
        {
            Champion champion = new Champion();
            champion.ChampionID = championID;
            champion.ChampionName = championName;
            champion.initialStr = initialStr;
            champion.initialAgi = initialAgi;
            champion.initialint = initialint;
            champion.strGrowth = strGrowth;
            champion.agiGrowth = agiGrowth;
            champion.intGrowth = intGrowth;
            champion.movSpeed = movSpeed;
            champion.armor = armor;
            champion.range = range;
            return champion;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ChampionID
        {
            get
            {
                return _ChampionID;
            }
            set
            {
                if (_ChampionID != value)
                {
                    OnChampionIDChanging(value);
                    ReportPropertyChanging("ChampionID");
                    _ChampionID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ChampionID");
                    OnChampionIDChanged();
                }
            }
        }
        private global::System.Int32 _ChampionID;
        partial void OnChampionIDChanging(global::System.Int32 value);
        partial void OnChampionIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ChampionName
        {
            get
            {
                return _ChampionName;
            }
            set
            {
                OnChampionNameChanging(value);
                ReportPropertyChanging("ChampionName");
                _ChampionName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ChampionName");
                OnChampionNameChanged();
            }
        }
        private global::System.String _ChampionName;
        partial void OnChampionNameChanging(global::System.String value);
        partial void OnChampionNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double initialStr
        {
            get
            {
                return _initialStr;
            }
            set
            {
                OninitialStrChanging(value);
                ReportPropertyChanging("initialStr");
                _initialStr = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("initialStr");
                OninitialStrChanged();
            }
        }
        private global::System.Double _initialStr;
        partial void OninitialStrChanging(global::System.Double value);
        partial void OninitialStrChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double initialAgi
        {
            get
            {
                return _initialAgi;
            }
            set
            {
                OninitialAgiChanging(value);
                ReportPropertyChanging("initialAgi");
                _initialAgi = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("initialAgi");
                OninitialAgiChanged();
            }
        }
        private global::System.Double _initialAgi;
        partial void OninitialAgiChanging(global::System.Double value);
        partial void OninitialAgiChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double initialint
        {
            get
            {
                return _initialint;
            }
            set
            {
                OninitialintChanging(value);
                ReportPropertyChanging("initialint");
                _initialint = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("initialint");
                OninitialintChanged();
            }
        }
        private global::System.Double _initialint;
        partial void OninitialintChanging(global::System.Double value);
        partial void OninitialintChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double strGrowth
        {
            get
            {
                return _strGrowth;
            }
            set
            {
                OnstrGrowthChanging(value);
                ReportPropertyChanging("strGrowth");
                _strGrowth = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("strGrowth");
                OnstrGrowthChanged();
            }
        }
        private global::System.Double _strGrowth;
        partial void OnstrGrowthChanging(global::System.Double value);
        partial void OnstrGrowthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double agiGrowth
        {
            get
            {
                return _agiGrowth;
            }
            set
            {
                OnagiGrowthChanging(value);
                ReportPropertyChanging("agiGrowth");
                _agiGrowth = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("agiGrowth");
                OnagiGrowthChanged();
            }
        }
        private global::System.Double _agiGrowth;
        partial void OnagiGrowthChanging(global::System.Double value);
        partial void OnagiGrowthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double intGrowth
        {
            get
            {
                return _intGrowth;
            }
            set
            {
                OnintGrowthChanging(value);
                ReportPropertyChanging("intGrowth");
                _intGrowth = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("intGrowth");
                OnintGrowthChanged();
            }
        }
        private global::System.Double _intGrowth;
        partial void OnintGrowthChanging(global::System.Double value);
        partial void OnintGrowthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double movSpeed
        {
            get
            {
                return _movSpeed;
            }
            set
            {
                OnmovSpeedChanging(value);
                ReportPropertyChanging("movSpeed");
                _movSpeed = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("movSpeed");
                OnmovSpeedChanged();
            }
        }
        private global::System.Double _movSpeed;
        partial void OnmovSpeedChanging(global::System.Double value);
        partial void OnmovSpeedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double armor
        {
            get
            {
                return _armor;
            }
            set
            {
                OnarmorChanging(value);
                ReportPropertyChanging("armor");
                _armor = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("armor");
                OnarmorChanged();
            }
        }
        private global::System.Double _armor;
        partial void OnarmorChanging(global::System.Double value);
        partial void OnarmorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double range
        {
            get
            {
                return _range;
            }
            set
            {
                OnrangeChanging(value);
                ReportPropertyChanging("range");
                _range = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("range");
                OnrangeChanged();
            }
        }
        private global::System.Double _range;
        partial void OnrangeChanging(global::System.Double value);
        partial void OnrangeChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DOTA2BuildCalculatorModel", Name="Item")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Item : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Item object.
        /// </summary>
        /// <param name="itemID">Initial value of the ItemID property.</param>
        /// <param name="itemName">Initial value of the ItemName property.</param>
        /// <param name="cost">Initial value of the cost property.</param>
        /// <param name="strMod">Initial value of the strMod property.</param>
        /// <param name="intMod">Initial value of the intMod property.</param>
        /// <param name="agiMod">Initial value of the agiMod property.</param>
        /// <param name="damageMod">Initial value of the damageMod property.</param>
        /// <param name="allAttributesMod">Initial value of the allAttributesMod property.</param>
        public static Item CreateItem(global::System.Int32 itemID, global::System.String itemName, global::System.String cost, global::System.String strMod, global::System.String intMod, global::System.String agiMod, global::System.String damageMod, global::System.String allAttributesMod)
        {
            Item item = new Item();
            item.ItemID = itemID;
            item.ItemName = itemName;
            item.cost = cost;
            item.strMod = strMod;
            item.intMod = intMod;
            item.agiMod = agiMod;
            item.damageMod = damageMod;
            item.allAttributesMod = allAttributesMod;
            return item;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ItemID
        {
            get
            {
                return _ItemID;
            }
            set
            {
                if (_ItemID != value)
                {
                    OnItemIDChanging(value);
                    ReportPropertyChanging("ItemID");
                    _ItemID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ItemID");
                    OnItemIDChanged();
                }
            }
        }
        private global::System.Int32 _ItemID;
        partial void OnItemIDChanging(global::System.Int32 value);
        partial void OnItemIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ItemName
        {
            get
            {
                return _ItemName;
            }
            set
            {
                OnItemNameChanging(value);
                ReportPropertyChanging("ItemName");
                _ItemName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ItemName");
                OnItemNameChanged();
            }
        }
        private global::System.String _ItemName;
        partial void OnItemNameChanging(global::System.String value);
        partial void OnItemNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String cost
        {
            get
            {
                return _cost;
            }
            set
            {
                OncostChanging(value);
                ReportPropertyChanging("cost");
                _cost = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("cost");
                OncostChanged();
            }
        }
        private global::System.String _cost;
        partial void OncostChanging(global::System.String value);
        partial void OncostChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String strMod
        {
            get
            {
                return _strMod;
            }
            set
            {
                OnstrModChanging(value);
                ReportPropertyChanging("strMod");
                _strMod = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("strMod");
                OnstrModChanged();
            }
        }
        private global::System.String _strMod;
        partial void OnstrModChanging(global::System.String value);
        partial void OnstrModChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String intMod
        {
            get
            {
                return _intMod;
            }
            set
            {
                OnintModChanging(value);
                ReportPropertyChanging("intMod");
                _intMod = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("intMod");
                OnintModChanged();
            }
        }
        private global::System.String _intMod;
        partial void OnintModChanging(global::System.String value);
        partial void OnintModChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String agiMod
        {
            get
            {
                return _agiMod;
            }
            set
            {
                OnagiModChanging(value);
                ReportPropertyChanging("agiMod");
                _agiMod = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("agiMod");
                OnagiModChanged();
            }
        }
        private global::System.String _agiMod;
        partial void OnagiModChanging(global::System.String value);
        partial void OnagiModChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String damageMod
        {
            get
            {
                return _damageMod;
            }
            set
            {
                OndamageModChanging(value);
                ReportPropertyChanging("damageMod");
                _damageMod = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("damageMod");
                OndamageModChanged();
            }
        }
        private global::System.String _damageMod;
        partial void OndamageModChanging(global::System.String value);
        partial void OndamageModChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String allAttributesMod
        {
            get
            {
                return _allAttributesMod;
            }
            set
            {
                OnallAttributesModChanging(value);
                ReportPropertyChanging("allAttributesMod");
                _allAttributesMod = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("allAttributesMod");
                OnallAttributesModChanged();
            }
        }
        private global::System.String _allAttributesMod;
        partial void OnallAttributesModChanging(global::System.String value);
        partial void OnallAttributesModChanged();

        #endregion
    
    }

    #endregion
    
}
