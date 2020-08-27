// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FactoryChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class FactoryChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_LocationItem")]
    [Metadata("Changes CDO for Location.", "LocationChanges", false, false, false, "LocationChanges", 1049798, true, false, false, null)]
    protected LocationChanges_Environment _LocationItem;
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048768, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Environment _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_NCRLabelTxnMap")]
    [Metadata("Contains a match between a service and a label definition to be printed.", "NCRLabelMapChanges", false, false, false, "NCRLabelMapChanges", 1050619, false, true, false, null)]
    protected NCRLabelMapChanges_Environment _NCRLabelTxnMap;
    [Metadata("LongString", "", false, false, false, "String", 16778737, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_GeneralMessage")]
    protected Environment _GeneralMessage;
    [Metadata("Calendar that is used to translate the timestamp of when a transaction was performed into a specific manufacturing date and shift.", "MfgCalendar", false, false, false, "NamedObjectRef", 1049935, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_MfgCalendar")]
    protected Environment _MfgCalendar;
    [Metadata("Changes CDO for Location.", "LocationChanges", false, false, false, "LocationChanges", 1048899, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_Locations")]
    protected LocationChanges_Environment _Locations;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, false, "NamedObjectRef", 1050609, false, false, true, null)]
    protected Environment _PrintQueue;
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1050473, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_TrainingReqGroup")]
    protected Environment _TrainingReqGroup;
    [Metadata("Transactions for Nonconformance services", "NCRESigTxnMapChanges", false, false, false, "NCRESigTxnMapChanges", 1050351, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_ESigTxnMap")]
    protected NCRESigTxnMapChanges_Environment _ESigTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_SMTPTransport")]
    [Metadata("SMTP Transport", "SMTPTransport", false, false, false, "NamedObjectRef", 1051749, false, false, true, null)]
    protected Environment _SMTPTransport;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_DispatchRule")]
    [Metadata("Definition of the prioritization rules for the order that material is processed on the shop floor.  A dispatch rule can contain separate details for different types of transactions.", "DispatchRule", false, false, false, "NamedObjectRef", 1050380, false, false, true, null)]
    protected Environment _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_ModelingObjsToExclude")]
    [Metadata("ModelingObjsToExcludeChanges", "ModelingObjsToExcludeChanges", false, false, false, "ModelingObjsToExcludeChanges", 1053095, false, true, false, null)]
    protected ModelingObjsToExcludeChanges_Environment _ModelingObjsToExclude;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_PELabelTxnMap")]
    [Metadata("Contains a match between a service and a label definition to be printed.", "PELabelMapChanges", false, false, false, "PELabelMapChanges", 1052911, false, true, false, null)]
    protected PELabelMapChanges_Environment _PELabelTxnMap;
    [Metadata("Configuration settings specific to Change Management.", "ChangeMgtApplication", false, false, false, "NamedObjectRef", 1053253, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_ChangeMgtApplication")]
    protected Environment _ChangeMgtApplication;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_Organization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051060, false, false, true, null)]
    protected Environment _Organization;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_ContainerNumberingRule")]
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRule", false, false, false, "NamedObjectRef", 1051905, false, false, true, null)]
    protected Environment _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_RequireLocation")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048900, false, false, false, "0")]
    protected Environment _RequireLocation;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778733, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_DisplayGeneralMessage")]
    protected Environment _DisplayGeneralMessage;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_Enterprise")]
    [Metadata("The Enterprise refers to the highest level in the factory definition. The Enterprise can represent the company itself, or a large division of the company. An Enterprise can contain one or more factories.", "Enterprise", false, false, false, "NamedObjectRef", 1048898, false, false, true, null)]
    protected Environment _Enterprise;
    [Metadata("Number of days a container remains in the system (not archived) after it is closed", "", false, false, false, "Integer", 1048901, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_RetentionDays")]
    protected Environment _RetentionDays;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_ReportHeading")]
    [Metadata("Text for report headings", "", false, false, false, "String", 1048895, false, false, false, null)]
    protected Environment _ReportHeading;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049797, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_MaxTimeSinceMsgsRetrieved")]
    protected Environment _MaxTimeSinceMsgsRetrieved;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_ObjectToChange")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1049831, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Environment_Name")]
    protected new Environment _Name;

    public LocationChanges_Environment LocationItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocationItem), (object) value);
      }
      get
      {
        return (LocationChanges_Environment) this.PropertyGet(nameof (LocationItem));
      }
    }

    public WIPMsgDefMgrChanges_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public NCRLabelMapChanges_Environment NCRLabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRLabelTxnMap), (object) value);
      }
      get
      {
        return (NCRLabelMapChanges_Environment) this.PropertyGet(nameof (NCRLabelTxnMap));
      }
    }

    public Environment GeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GeneralMessage));
      }
    }

    public Environment MfgCalendar
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendar), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgCalendar));
      }
    }

    public LocationChanges_Environment Locations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Locations), (object) value);
      }
      get
      {
        return (LocationChanges_Environment) this.PropertyGet(nameof (Locations));
      }
    }

    public Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Environment TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public NCRESigTxnMapChanges_Environment ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (NCRESigTxnMapChanges_Environment) this.PropertyGet(nameof (ESigTxnMap));
      }
    }

    public Environment SMTPTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (SMTPTransport), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SMTPTransport));
      }
    }

    public Environment DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public ModelingObjsToExcludeChanges_Environment ModelingObjsToExclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingObjsToExclude), (object) value);
      }
      get
      {
        return (ModelingObjsToExcludeChanges_Environment) this.PropertyGet(nameof (ModelingObjsToExclude));
      }
    }

    public PELabelMapChanges_Environment PELabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (PELabelTxnMap), (object) value);
      }
      get
      {
        return (PELabelMapChanges_Environment) this.PropertyGet(nameof (PELabelTxnMap));
      }
    }

    public Environment ChangeMgtApplication
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeMgtApplication), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangeMgtApplication));
      }
    }

    public Environment Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organization));
      }
    }

    public Environment ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Environment RequireLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequireLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RequireLocation));
      }
    }

    public Environment DisplayGeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayGeneralMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayGeneralMessage));
      }
    }

    public Environment Enterprise
    {
      [param: In] set
      {
        this.PropertySet(nameof (Enterprise), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Enterprise));
      }
    }

    public Environment RetentionDays
    {
      [param: In] set
      {
        this.PropertySet(nameof (RetentionDays), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RetentionDays));
      }
    }

    public Environment ReportHeading
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportHeading), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportHeading));
      }
    }

    public Environment MaxTimeSinceMsgsRetrieved
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTimeSinceMsgsRetrieved), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxTimeSinceMsgsRetrieved));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
