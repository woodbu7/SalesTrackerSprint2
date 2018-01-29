﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TheTravelingSalesperson
{
    public class Product
    {
        #region Enumerables
        public enum ProductType
        {
            None,
            Furry, 
            Spotted,
            Dancing
        }

        #endregion

        #region Fields

        private int _numberOfUnits;
        private bool _onBackorder;
        private ProductType _type;

        #endregion

        #region Properties

        public int NumberOfUnits
        {
            get { return _numberOfUnits; }
        }

        public bool OnBackorder
        {
            get { return _onBackorder; }
            set { _onBackorder = value; }
        }

        public ProductType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        #endregion

        #region Constructors

        public Product()
        {
            _type = ProductType.None;
            _numberOfUnits = 0;
        }

        public Product(ProductType type, int numberOfUnits)
        {
            _type = type;
            _numberOfUnits = numberOfUnits;
        }

        #endregion

        #region Methods

        /// <summary>
        /// increments NumberOfUnits property
        /// </summary>
        /// <param name="unitsToAdd"></param>
        public void AddProducts(int unitsToAdd)
        {
            _numberOfUnits += unitsToAdd;
        }

        /// <summary>
        /// decrements NumberOfUnits property and sets OnBackorder status
        /// </summary>
        /// <param name="unitsToSubtract"></param>
        public void SubtractProducts(int unitsToSubtract)
        {
            if (_numberOfUnits < unitsToSubtract)
            {
                _onBackorder = true;
            }

            _numberOfUnits -= unitsToSubtract;
        }

        #endregion
    }
}
