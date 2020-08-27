// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCChartDefChanges_Environment
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
  public class SPCChartDefChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("E-mail Address", "", false, false, false, "String", 1052612, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_EmailNotification")]
    protected Environment _EmailNotification;
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, false, "NamedObjectRef", 1052614, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_PutContainerOnHold")]
    protected Environment _PutContainerOnHold;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_EMailMessage")]
    [Metadata("EMail with details to be used in sending email.", "EMailMessage", false, false, false, "NamedObjectRef", 1051744, false, false, true, null)]
    protected Environment _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_SPCChartDisplayOption")]
    [Metadata("SPCChartDisplayOption", "SPCChartDisplayOptionEnum", false, true, false, "Integer", 1053034, false, false, true, null)]
    protected Environment _SPCChartDisplayOption;
    [Metadata("Defines SPC Charting information for a variable/chart type combination.  Includes designation for rules file, macro, display options, OCAPs and 10 user params to use during chart generation, display and OCAP processing", "SPCChartDef", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Generic String", "", false, false, false, "String", 1052624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_UserParm5")]
    protected Environment _UserParm5;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052616, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_RunTimeDisplay")]
    protected Environment _RunTimeDisplay;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_UserParm3")]
    [Metadata("Generic String", "", false, false, false, "String", 1052622, false, false, false, null)]
    protected Environment _UserParm3;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052615, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_RequireAnnotation")]
    protected Environment _RequireAnnotation;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052610, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_DisplayOnException")]
    protected Environment _DisplayOnException;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_ChartHeight")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052605, false, false, false, null)]
    protected Environment _ChartHeight;
    [Metadata("Generic String", "", false, false, false, "String", 1052625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_UserParm6")]
    protected Environment _UserParm6;
    [Metadata("Generic String", "", false, false, false, "String", 1052627, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_UserParm8")]
    protected Environment _UserParm8;
    [Metadata("Generic String", "", false, false, false, "String", 1052628, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_UserParm9")]
    protected Environment _UserParm9;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_TriggerOCAPs")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052618, false, false, false, "0")]
    protected Environment _TriggerOCAPs;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_UserParm4")]
    [Metadata("Generic String", "", false, false, false, "String", 1052623, false, false, false, null)]
    protected Environment _UserParm4;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_RecordAgainstCustomSPCDataSrc")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053052, false, false, false, "0")]
    protected Environment _RecordAgainstCustomSPCDataSrc;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_ChartType")]
    [Metadata("Generic String", "", false, true, false, "String", 1052607, false, false, false, null)]
    protected Environment _ChartType;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_UserParm10")]
    [Metadata("Generic String", "", false, false, false, "String", 1052620, false, false, false, null)]
    protected Environment _UserParm10;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_UserParm1")]
    [Metadata("Generic String", "", false, false, false, "String", 1052619, false, false, false, null)]
    protected Environment _UserParm1;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_UserParm7")]
    [Metadata("Generic String", "", false, false, false, "String", 1052626, false, false, false, null)]
    protected Environment _UserParm7;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_ChartWidth")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052609, false, false, false, null)]
    protected Environment _ChartWidth;
    [Metadata("Generic String", "", false, false, false, "String", 1052621, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_UserParm2")]
    protected Environment _UserParm2;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_ChartVariable")]
    [Metadata("Generic String", "", false, true, false, "String", 1052608, false, false, false, null)]
    protected Environment _ChartVariable;
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, false, "NamedObjectRef", 1052617, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_SetResourceStatus")]
    protected Environment _SetResourceStatus;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 1052611, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_DocToView")]
    protected Environment _DocToView;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052629, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_ChartProperties")]
    [Metadata("Optionally specifies the directory to be used as the current directory when the application is launched.", "", false, false, false, "String", 1052639, false, false, false, null)]
    protected Environment _ChartProperties;
    [Metadata("Optionally specifies the directory to be used as the current directory when the application is launched.", "", false, true, false, "String", 1052640, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Environment_Macro")]
    protected Environment _Macro;

    public Environment EmailNotification
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmailNotification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EmailNotification));
      }
    }

    public Environment PutContainerOnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (PutContainerOnHold), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PutContainerOnHold));
      }
    }

    public Environment EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public Environment SPCChartDisplayOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDisplayOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SPCChartDisplayOption));
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

    public Environment UserParm5
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm5), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserParm5));
      }
    }

    public Environment RunTimeDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (RunTimeDisplay), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RunTimeDisplay));
      }
    }

    public Environment UserParm3
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm3), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserParm3));
      }
    }

    public Environment RequireAnnotation
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequireAnnotation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RequireAnnotation));
      }
    }

    public Environment DisplayOnException
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayOnException), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayOnException));
      }
    }

    public Environment ChartHeight
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartHeight), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChartHeight));
      }
    }

    public Environment UserParm6
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm6), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserParm6));
      }
    }

    public Environment UserParm8
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm8), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserParm8));
      }
    }

    public Environment UserParm9
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm9), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserParm9));
      }
    }

    public Environment TriggerOCAPs
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriggerOCAPs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriggerOCAPs));
      }
    }

    public Environment UserParm4
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm4), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserParm4));
      }
    }

    public Environment RecordAgainstCustomSPCDataSrc
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAgainstCustomSPCDataSrc), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordAgainstCustomSPCDataSrc));
      }
    }

    public Environment ChartType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChartType));
      }
    }

    public Environment UserParm10
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm10), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserParm10));
      }
    }

    public Environment UserParm1
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm1), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserParm1));
      }
    }

    public Environment UserParm7
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm7), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserParm7));
      }
    }

    public Environment ChartWidth
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartWidth), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChartWidth));
      }
    }

    public Environment UserParm2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserParm2));
      }
    }

    public Environment ChartVariable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartVariable), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChartVariable));
      }
    }

    public Environment SetResourceStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetResourceStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SetResourceStatus));
      }
    }

    public Environment DocToView
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocToView), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocToView));
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

    public Environment ChartProperties
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartProperties), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChartProperties));
      }
    }

    public Environment Macro
    {
      [param: In] set
      {
        this.PropertySet(nameof (Macro), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Macro));
      }
    }
  }
}
