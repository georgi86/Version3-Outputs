﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Outputs
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the OutputsRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    [RepositoryFolder("751869b6-9822-4c6e-9498-0703eadb8e84")]
    public partial class OutputsRepository : RepoGenBaseFolder
    {
        static OutputsRepository instance = new OutputsRepository();
        OutputsRepositoryFolders.SnapXUntitledAppFolder _snapxuntitled;
        OutputsRepositoryFolders.OpenSnapXRoutineAppFolder _opensnapxroutine;
        OutputsRepositoryFolders.StatisticSTANotepadAppFolder _statisticstanotepad;
        OutputsRepositoryFolders.ReportStaNotepadAppFolder _reportstanotepad;
        OutputsRepositoryFolders.PrintPRTNotepadAppFolder _printprtnotepad;
        OutputsRepositoryFolders.ExportStaNotepadAppFolder _exportstanotepad;
        OutputsRepositoryFolders.DatastreamDatNotepadAppFolder _datastreamdatnotepad;
        OutputsRepositoryFolders.ExcelXlsNotepadAppFolder _excelxlsnotepad;
        OutputsRepositoryFolders.ComputerAppFolder _computer;
        OutputsRepositoryFolders.ExplorerAppFolder _explorer;
        OutputsRepositoryFolders.Explorer1AppFolder _explorer1;
        OutputsRepositoryFolders.ReportsAppFolder _reports;

        /// <summary>
        /// Gets the singleton class instance representing the OutputsRepository element repository.
        /// </summary>
        [RepositoryFolder("751869b6-9822-4c6e-9498-0703eadb8e84")]
        public static OutputsRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public OutputsRepository() 
            : base("OutputsRepository", "/", null, 0, false, "751869b6-9822-4c6e-9498-0703eadb8e84", ".\\RepositoryImages\\OutputsRepository751869b6.rximgres")
        {
            _snapxuntitled = new OutputsRepositoryFolders.SnapXUntitledAppFolder(this);
            _opensnapxroutine = new OutputsRepositoryFolders.OpenSnapXRoutineAppFolder(this);
            _statisticstanotepad = new OutputsRepositoryFolders.StatisticSTANotepadAppFolder(this);
            _reportstanotepad = new OutputsRepositoryFolders.ReportStaNotepadAppFolder(this);
            _printprtnotepad = new OutputsRepositoryFolders.PrintPRTNotepadAppFolder(this);
            _exportstanotepad = new OutputsRepositoryFolders.ExportStaNotepadAppFolder(this);
            _datastreamdatnotepad = new OutputsRepositoryFolders.DatastreamDatNotepadAppFolder(this);
            _excelxlsnotepad = new OutputsRepositoryFolders.ExcelXlsNotepadAppFolder(this);
            _computer = new OutputsRepositoryFolders.ComputerAppFolder(this);
            _explorer = new OutputsRepositoryFolders.ExplorerAppFolder(this);
            _explorer1 = new OutputsRepositoryFolders.Explorer1AppFolder(this);
            _reports = new OutputsRepositoryFolders.ReportsAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("751869b6-9822-4c6e-9498-0703eadb8e84")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SnapXUntitled folder.
        /// </summary>
        [RepositoryFolder("43775787-6981-45c9-a854-418cd535d936")]
        public virtual OutputsRepositoryFolders.SnapXUntitledAppFolder SnapXUntitled
        {
            get { return _snapxuntitled; }
        }

        /// <summary>
        /// The OpenSnapXRoutine folder.
        /// </summary>
        [RepositoryFolder("049be60f-5b9d-41ef-833c-468f15aa4077")]
        public virtual OutputsRepositoryFolders.OpenSnapXRoutineAppFolder OpenSnapXRoutine
        {
            get { return _opensnapxroutine; }
        }

        /// <summary>
        /// The StatisticSTANotepad folder.
        /// </summary>
        [RepositoryFolder("9b8033e3-2ed6-41f3-9e88-daefd145b3ce")]
        public virtual OutputsRepositoryFolders.StatisticSTANotepadAppFolder StatisticSTANotepad
        {
            get { return _statisticstanotepad; }
        }

        /// <summary>
        /// The ReportStaNotepad folder.
        /// </summary>
        [RepositoryFolder("950330e5-038b-43c1-a217-a23cbf6163c0")]
        public virtual OutputsRepositoryFolders.ReportStaNotepadAppFolder ReportStaNotepad
        {
            get { return _reportstanotepad; }
        }

        /// <summary>
        /// The PrintPRTNotepad folder.
        /// </summary>
        [RepositoryFolder("c0b53c29-718d-473c-aad2-980d5c9449e1")]
        public virtual OutputsRepositoryFolders.PrintPRTNotepadAppFolder PrintPRTNotepad
        {
            get { return _printprtnotepad; }
        }

        /// <summary>
        /// The ExportStaNotepad folder.
        /// </summary>
        [RepositoryFolder("00eece80-a99d-429d-a91c-98bee5f41fc2")]
        public virtual OutputsRepositoryFolders.ExportStaNotepadAppFolder ExportStaNotepad
        {
            get { return _exportstanotepad; }
        }

        /// <summary>
        /// The DatastreamDatNotepad folder.
        /// </summary>
        [RepositoryFolder("11c49540-7e7b-4431-8773-15d87943d08f")]
        public virtual OutputsRepositoryFolders.DatastreamDatNotepadAppFolder DatastreamDatNotepad
        {
            get { return _datastreamdatnotepad; }
        }

        /// <summary>
        /// The ExcelXlsNotepad folder.
        /// </summary>
        [RepositoryFolder("ad4acfd6-006c-41da-945d-dc2ddbcbaf1c")]
        public virtual OutputsRepositoryFolders.ExcelXlsNotepadAppFolder ExcelXlsNotepad
        {
            get { return _excelxlsnotepad; }
        }

        /// <summary>
        /// The Computer folder.
        /// </summary>
        [RepositoryFolder("0168a895-7531-4468-af45-395fc5377c78")]
        public virtual OutputsRepositoryFolders.ComputerAppFolder Computer
        {
            get { return _computer; }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("e6f55bc6-fc32-4fc1-8dfa-a3200f265f1a")]
        public virtual OutputsRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }

        /// <summary>
        /// The Explorer1 folder.
        /// </summary>
        [RepositoryFolder("a7ec701c-a1c1-444b-a657-a15caf51fd59")]
        public virtual OutputsRepositoryFolders.Explorer1AppFolder Explorer1
        {
            get { return _explorer1; }
        }

        /// <summary>
        /// The Reports folder.
        /// </summary>
        [RepositoryFolder("ffe8e865-b446-4b82-9588-622e1e99e9c2")]
        public virtual OutputsRepositoryFolders.ReportsAppFolder Reports
        {
            get { return _reports; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    public partial class OutputsRepositoryFolders
    {
        /// <summary>
        /// The SnapXUntitledAppFolder folder.
        /// </summary>
        [RepositoryFolder("43775787-6981-45c9-a854-418cd535d936")]
        public partial class SnapXUntitledAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _element94Info;
            RepoItemInfo _buttonokInfo;            
            RepoItemInfo _finishInfo;
            RepoItemInfo _buttongoInfo;

            /// <summary>
            /// Creates a new SnapXUntitled  folder.
            /// </summary>
            public SnapXUntitledAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SnapXUntitled", "/form[@title='Snap-X - [Untitled]']", parentFolder, 30000, null, true, "43775787-6981-45c9-a854-418cd535d936", "")
            {
                _element94Info = new RepoItemInfo(this, "Element94", "element[@controlid='94']", 30000, null, "76c8b8ce-92bd-450a-8977-236f63e76e7d");                
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "container/form//button[@text='&OK']", 500000, null, "f7b05518-65b8-4d1a-b3d0-ef4b40182a53");                
                _finishInfo = new RepoItemInfo(this, "Finish", "container[@controlid='59648']//button[@text='Finish' and @enabled='True']", 30000, null, "b11eaeb2-faaa-46af-998b-14a7402099c8");
                _buttongoInfo = new RepoItemInfo(this, "ButtonGo", "container[@controlid='59648']/form[@title='Untitled']//element[@controlid='59664']/container[@controlid='59648']/button[@text='Go']", 30000, null, "eb68633c-8ac4-4316-8071-80e5d53e7ba6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("43775787-6981-45c9-a854-418cd535d936")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("43775787-6981-45c9-a854-418cd535d936")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SnapXUntitled item.
            /// </summary>
            [RepositoryItem("76c8b8ce-92bd-450a-8977-236f63e76e7d")]
            public virtual Ranorex.Unknown Element94
            {
                get
                {
                    return _element94Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Element94 item info.
            /// </summary>
            [RepositoryItemInfo("76c8b8ce-92bd-450a-8977-236f63e76e7d")]
            public virtual RepoItemInfo Element94Info
            {
                get
                {
                    return _element94Info;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("ad493450-7358-4e88-830e-9afd6077d9fe")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("ad493450-7358-4e88-830e-9afd6077d9fe")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }



            /// <summary>
            /// The Finish item.
            /// </summary>
            [RepositoryItem("b11eaeb2-faaa-46af-998b-14a7402099c8")]
            public virtual Ranorex.Button Finish
            {
                get
                {
                    return _finishInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Finish item info.
            /// </summary>
            [RepositoryItemInfo("b11eaeb2-faaa-46af-998b-14a7402099c8")]
            public virtual RepoItemInfo FinishInfo
            {
                get
                {
                    return _finishInfo;
                }
            }

            [RepositoryItem("eb68633c-8ac4-4316-8071-80e5d53e7ba6")]
            public virtual Ranorex.Button ButtonGo
            {
                get
                {
                    return _buttongoInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonGo item info.
            /// </summary>
            [RepositoryItemInfo("eb68633c-8ac4-4316-8071-80e5d53e7ba6")]
            public virtual RepoItemInfo ButtonGoInfo
            {
                get
                {
                    return _buttongoInfo;
                }
            }
        }

        /// <summary>
        /// The OpenSnapXRoutineAppFolder folder.
        /// </summary>
        [RepositoryFolder("049be60f-5b9d-41ef-833c-468f15aa4077")]
        public partial class OpenSnapXRoutineAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text1148Info;

            /// <summary>
            /// Creates a new OpenSnapXRoutine  folder.
            /// </summary>
            public OpenSnapXRoutineAppFolder(RepoGenBaseFolder parentFolder) :
                    base("OpenSnapXRoutine", "/form[@title='Open Snap-X Routine']", parentFolder, 30000, null, true, "049be60f-5b9d-41ef-833c-468f15aa4077", "")
            {
                _text1148Info = new RepoItemInfo(this, "Text1148", "?/?/text[@controlid='1148']", 30000, null, "c0adf465-8939-4d95-836f-192dfd9f4d69");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("049be60f-5b9d-41ef-833c-468f15aa4077")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("049be60f-5b9d-41ef-833c-468f15aa4077")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text1148 item.
            /// </summary>
            [RepositoryItem("c0adf465-8939-4d95-836f-192dfd9f4d69")]
            public virtual Ranorex.Text Text1148
            {
                get
                {
                    return _text1148Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text1148 item info.
            /// </summary>
            [RepositoryItemInfo("c0adf465-8939-4d95-836f-192dfd9f4d69")]
            public virtual RepoItemInfo Text1148Info
            {
                get
                {
                    return _text1148Info;
                }
            }
        }

        /// <summary>
        /// The StatisticSTANotepadAppFolder folder.
        /// </summary>
        [RepositoryFolder("9b8033e3-2ed6-41f3-9e88-daefd145b3ce")]
        public partial class StatisticSTANotepadAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text15Info;

            /// <summary>
            /// Creates a new StatisticSTANotepad  folder.
            /// </summary>
            public StatisticSTANotepadAppFolder(RepoGenBaseFolder parentFolder) :
                    base("StatisticSTANotepad", "/form[@title='statistic.STA - Notepad']", parentFolder, 30000, null, true, "9b8033e3-2ed6-41f3-9e88-daefd145b3ce", "")
            {
                _text15Info = new RepoItemInfo(this, "Text15", "text[@controlid='15']", 30000, null, "38f2a400-a4e9-43f1-93ec-00e22f4b56d5");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9b8033e3-2ed6-41f3-9e88-daefd145b3ce")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9b8033e3-2ed6-41f3-9e88-daefd145b3ce")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text15 item.
            /// </summary>
            [RepositoryItem("38f2a400-a4e9-43f1-93ec-00e22f4b56d5")]
            public virtual Ranorex.Text Text15
            {
                get
                {
                    return _text15Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text15 item info.
            /// </summary>
            [RepositoryItemInfo("38f2a400-a4e9-43f1-93ec-00e22f4b56d5")]
            public virtual RepoItemInfo Text15Info
            {
                get
                {
                    return _text15Info;
                }
            }
        }

        /// <summary>
        /// The ReportStaNotepadAppFolder folder.
        /// </summary>
        [RepositoryFolder("950330e5-038b-43c1-a217-a23cbf6163c0")]
        public partial class ReportStaNotepadAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text15Info;

            /// <summary>
            /// Creates a new ReportStaNotepad  folder.
            /// </summary>
            public ReportStaNotepadAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ReportStaNotepad", "/form[@title='report.sta - Notepad']", parentFolder, 30000, null, true, "950330e5-038b-43c1-a217-a23cbf6163c0", "")
            {
                _text15Info = new RepoItemInfo(this, "Text15", "text[@controlid='15']", 30000, null, "1cdc580d-4a90-46c4-acad-7e5348bf4e85");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("950330e5-038b-43c1-a217-a23cbf6163c0")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("950330e5-038b-43c1-a217-a23cbf6163c0")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text15 item.
            /// </summary>
            [RepositoryItem("1cdc580d-4a90-46c4-acad-7e5348bf4e85")]
            public virtual Ranorex.Text Text15
            {
                get
                {
                    return _text15Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text15 item info.
            /// </summary>
            [RepositoryItemInfo("1cdc580d-4a90-46c4-acad-7e5348bf4e85")]
            public virtual RepoItemInfo Text15Info
            {
                get
                {
                    return _text15Info;
                }
            }
        }

        /// <summary>
        /// The PrintPRTNotepadAppFolder folder.
        /// </summary>
        [RepositoryFolder("c0b53c29-718d-473c-aad2-980d5c9449e1")]
        public partial class PrintPRTNotepadAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text15Info;

            /// <summary>
            /// Creates a new PrintPRTNotepad  folder.
            /// </summary>
            public PrintPRTNotepadAppFolder(RepoGenBaseFolder parentFolder) :
                    base("PrintPRTNotepad", "/form[@title='print.PRT - Notepad']", parentFolder, 30000, null, true, "c0b53c29-718d-473c-aad2-980d5c9449e1", "")
            {
                _text15Info = new RepoItemInfo(this, "Text15", "text[@controlid='15']", 30000, null, "a7ca3844-b299-4b2b-bb9f-d972f349774d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c0b53c29-718d-473c-aad2-980d5c9449e1")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c0b53c29-718d-473c-aad2-980d5c9449e1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text15 item.
            /// </summary>
            [RepositoryItem("a7ca3844-b299-4b2b-bb9f-d972f349774d")]
            public virtual Ranorex.Text Text15
            {
                get
                {
                    return _text15Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text15 item info.
            /// </summary>
            [RepositoryItemInfo("a7ca3844-b299-4b2b-bb9f-d972f349774d")]
            public virtual RepoItemInfo Text15Info
            {
                get
                {
                    return _text15Info;
                }
            }
        }

        /// <summary>
        /// The ExportStaNotepadAppFolder folder.
        /// </summary>
        [RepositoryFolder("00eece80-a99d-429d-a91c-98bee5f41fc2")]
        public partial class ExportStaNotepadAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text15Info;

            /// <summary>
            /// Creates a new ExportStaNotepad  folder.
            /// </summary>
            public ExportStaNotepadAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ExportStaNotepad", "/form[@title='export.sta - Notepad']", parentFolder, 30000, null, true, "00eece80-a99d-429d-a91c-98bee5f41fc2", "")
            {
                _text15Info = new RepoItemInfo(this, "Text15", "text[@controlid='15']", 30000, null, "c5579505-602f-4ac1-b0ba-cb08c68a4d03");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("00eece80-a99d-429d-a91c-98bee5f41fc2")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("00eece80-a99d-429d-a91c-98bee5f41fc2")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text15 item.
            /// </summary>
            [RepositoryItem("c5579505-602f-4ac1-b0ba-cb08c68a4d03")]
            public virtual Ranorex.Text Text15
            {
                get
                {
                    return _text15Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text15 item info.
            /// </summary>
            [RepositoryItemInfo("c5579505-602f-4ac1-b0ba-cb08c68a4d03")]
            public virtual RepoItemInfo Text15Info
            {
                get
                {
                    return _text15Info;
                }
            }
        }

        /// <summary>
        /// The DatastreamDatNotepadAppFolder folder.
        /// </summary>
        [RepositoryFolder("11c49540-7e7b-4431-8773-15d87943d08f")]
        public partial class DatastreamDatNotepadAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text15Info;

            /// <summary>
            /// Creates a new DatastreamDatNotepad  folder.
            /// </summary>
            public DatastreamDatNotepadAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DatastreamDatNotepad", "/form[@title='datastream.dat - Notepad']", parentFolder, 30000, null, true, "11c49540-7e7b-4431-8773-15d87943d08f", "")
            {
                _text15Info = new RepoItemInfo(this, "Text15", "text[@controlid='15']", 30000, null, "a0701b51-574a-4b79-80e2-b20b683493a8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("11c49540-7e7b-4431-8773-15d87943d08f")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("11c49540-7e7b-4431-8773-15d87943d08f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text15 item.
            /// </summary>
            [RepositoryItem("a0701b51-574a-4b79-80e2-b20b683493a8")]
            public virtual Ranorex.Text Text15
            {
                get
                {
                    return _text15Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text15 item info.
            /// </summary>
            [RepositoryItemInfo("a0701b51-574a-4b79-80e2-b20b683493a8")]
            public virtual RepoItemInfo Text15Info
            {
                get
                {
                    return _text15Info;
                }
            }
        }

        /// <summary>
        /// The ExcelXlsNotepadAppFolder folder.
        /// </summary>
        [RepositoryFolder("ad4acfd6-006c-41da-945d-dc2ddbcbaf1c")]
        public partial class ExcelXlsNotepadAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text15Info;

            /// <summary>
            /// Creates a new ExcelXlsNotepad  folder.
            /// </summary>
            public ExcelXlsNotepadAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ExcelXlsNotepad", "/form[@title='excel.xls - Notepad']", parentFolder, 30000, null, true, "ad4acfd6-006c-41da-945d-dc2ddbcbaf1c", "")
            {
                _text15Info = new RepoItemInfo(this, "Text15", "text[@controlid='15']", 30000, null, "dbee7f26-4aa0-4689-92fa-d88fc765622b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ad4acfd6-006c-41da-945d-dc2ddbcbaf1c")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ad4acfd6-006c-41da-945d-dc2ddbcbaf1c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text15 item.
            /// </summary>
            [RepositoryItem("dbee7f26-4aa0-4689-92fa-d88fc765622b")]
            public virtual Ranorex.Text Text15
            {
                get
                {
                    return _text15Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text15 item info.
            /// </summary>
            [RepositoryItemInfo("dbee7f26-4aa0-4689-92fa-d88fc765622b")]
            public virtual RepoItemInfo Text15Info
            {
                get
                {
                    return _text15Info;
                }
            }
        }

        /// <summary>
        /// The ComputerAppFolder folder.
        /// </summary>
        [RepositoryFolder("0168a895-7531-4468-af45-395fc5377c78")]
        public partial class ComputerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _toolbar1001Info;
            RepoItemInfo _systemitemnamedisplayInfo;

            /// <summary>
            /// Creates a new Computer  folder.
            /// </summary>
            public ComputerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Computer", "/form[@title='Computer']", parentFolder, 30000, null, true, "0168a895-7531-4468-af45-395fc5377c78", "")
            {
                _toolbar1001Info = new RepoItemInfo(this, "ToolBar1001", "element[@class='WorkerW']/?/?/element//toolbar[@controlid='1001']", 30000, null, "d562d20f-a3c3-438d-ac40-1b7fdaaabbd1");
                _systemitemnamedisplayInfo = new RepoItemInfo(this, "SystemItemNameDisplay", ".//element/container[@caption='ShellView']/?/?/listitem[@text='excel.xls']/text[@automationid='System.ItemNameDisplay']", 30000, null, "456ced00-887e-414b-ac20-4859513c4b15");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0168a895-7531-4468-af45-395fc5377c78")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("0168a895-7531-4468-af45-395fc5377c78")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ToolBar1001 item.
            /// </summary>
            [RepositoryItem("d562d20f-a3c3-438d-ac40-1b7fdaaabbd1")]
            public virtual Ranorex.ToolBar ToolBar1001
            {
                get
                {
                    return _toolbar1001Info.CreateAdapter<Ranorex.ToolBar>(true);
                }
            }

            /// <summary>
            /// The ToolBar1001 item info.
            /// </summary>
            [RepositoryItemInfo("d562d20f-a3c3-438d-ac40-1b7fdaaabbd1")]
            public virtual RepoItemInfo ToolBar1001Info
            {
                get
                {
                    return _toolbar1001Info;
                }
            }

            /// <summary>
            /// The SystemItemNameDisplay item.
            /// </summary>
            [RepositoryItem("456ced00-887e-414b-ac20-4859513c4b15")]
            public virtual Ranorex.Text SystemItemNameDisplay
            {
                get
                {
                    return _systemitemnamedisplayInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SystemItemNameDisplay item info.
            /// </summary>
            [RepositoryItemInfo("456ced00-887e-414b-ac20-4859513c4b15")]
            public virtual RepoItemInfo SystemItemNameDisplayInfo
            {
                get
                {
                    return _systemitemnamedisplayInfo;
                }
            }
        }

        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("e6f55bc6-fc32-4fc1-8dfa-a3200f265f1a")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _openwithInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/contextmenu[@class='#32768' and @instance='0']", parentFolder, 30000, null, false, "e6f55bc6-fc32-4fc1-8dfa-a3200f265f1a", "")
            {
                _openwithInfo = new RepoItemInfo(this, "OpenWith", "?/?/menuitem[@accessiblename='Open with']", 30000, null, "1cdae9d8-a2bc-4109-8d87-2ffc982ec010");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e6f55bc6-fc32-4fc1-8dfa-a3200f265f1a")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e6f55bc6-fc32-4fc1-8dfa-a3200f265f1a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The OpenWith item.
            /// </summary>
            [RepositoryItem("1cdae9d8-a2bc-4109-8d87-2ffc982ec010")]
            public virtual Ranorex.MenuItem OpenWith
            {
                get
                {
                    return _openwithInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The OpenWith item info.
            /// </summary>
            [RepositoryItemInfo("1cdae9d8-a2bc-4109-8d87-2ffc982ec010")]
            public virtual RepoItemInfo OpenWithInfo
            {
                get
                {
                    return _openwithInfo;
                }
            }
        }

        /// <summary>
        /// The Explorer1AppFolder folder.
        /// </summary>
        [RepositoryFolder("a7ec701c-a1c1-444b-a657-a15caf51fd59")]
        public partial class Explorer1AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _microsoftexcelInfo;
            RepoItemInfo _notepadInfo;

            /// <summary>
            /// Creates a new Explorer1  folder.
            /// </summary>
            public Explorer1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer1", "/contextmenu[@class='#32768' and @instance='1']", parentFolder, 30000, null, false, "a7ec701c-a1c1-444b-a657-a15caf51fd59", "")
            {
                _microsoftexcelInfo = new RepoItemInfo(this, "MicrosoftExcel", "?/?/menuitem[@accessiblename='Microsoft Excel']", 30000, null, "c5355cf0-7b45-4bc2-a4db-a301c4226e9f");
                _notepadInfo = new RepoItemInfo(this, "Notepad", "?/?/menuitem[@accessiblename='Notepad' and @text='Notepad']", 30000, null, "e461bdc0-6dd7-4701-87f3-ef0f5953acb7");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a7ec701c-a1c1-444b-a657-a15caf51fd59")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a7ec701c-a1c1-444b-a657-a15caf51fd59")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MicrosoftExcel item.
            /// </summary>
            [RepositoryItem("c5355cf0-7b45-4bc2-a4db-a301c4226e9f")]
            public virtual Ranorex.MenuItem MicrosoftExcel
            {
                get
                {
                    return _microsoftexcelInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MicrosoftExcel item info.
            /// </summary>
            [RepositoryItemInfo("c5355cf0-7b45-4bc2-a4db-a301c4226e9f")]
            public virtual RepoItemInfo MicrosoftExcelInfo
            {
                get
                {
                    return _microsoftexcelInfo;
                }
            }

            /// <summary>
            /// The Notepad item.
            /// </summary>
            [RepositoryItem("e461bdc0-6dd7-4701-87f3-ef0f5953acb7")]
            public virtual Ranorex.MenuItem Notepad
            {
                get
                {
                    return _notepadInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Notepad item info.
            /// </summary>
            [RepositoryItemInfo("e461bdc0-6dd7-4701-87f3-ef0f5953acb7")]
            public virtual RepoItemInfo NotepadInfo
            {
                get
                {
                    return _notepadInfo;
                }
            }
        }

        /// <summary>
        /// The ReportsAppFolder folder.
        /// </summary>
        [RepositoryFolder("ffe8e865-b446-4b82-9588-622e1e99e9c2")]
        public partial class ReportsAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _listitem4Info;

            /// <summary>
            /// Creates a new Reports  folder.
            /// </summary>
            public ReportsAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Reports", "/form[@processname='explorer' and @class='CabinetWClass' and @instance='1']", parentFolder, 30000, null, true, "ffe8e865-b446-4b82-9588-622e1e99e9c2", "")
            {
                _listitem4Info = new RepoItemInfo(this, "ListItem4", ".//element/container[@caption='ShellView']/container[@class='DirectUIHWND']/listitem[@text='excel.xls']", 30000, null, "e8e5a232-b19b-4c45-91d5-f2968065a7b9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ffe8e865-b446-4b82-9588-622e1e99e9c2")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ffe8e865-b446-4b82-9588-622e1e99e9c2")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ListItem4 item.
            /// </summary>
            [RepositoryItem("e8e5a232-b19b-4c45-91d5-f2968065a7b9")]
            public virtual Ranorex.ListItem ListItem4
            {
                get
                {
                    return _listitem4Info.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ListItem4 item info.
            /// </summary>
            [RepositoryItemInfo("e8e5a232-b19b-4c45-91d5-f2968065a7b9")]
            public virtual RepoItemInfo ListItem4Info
            {
                get
                {
                    return _listitem4Info;
                }
            }

            
        }

    }
#pragma warning restore 0436
}