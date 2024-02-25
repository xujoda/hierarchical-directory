﻿using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public interface IXmlExporter
    {
        void ExportToXml(string filePath, Company company);
    }
}
