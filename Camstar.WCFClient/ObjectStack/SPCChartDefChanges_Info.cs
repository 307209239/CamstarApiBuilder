// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCChartDefChanges_Info
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
  public class SPCChartDefChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_EmailNotification")]
    protected Info _EmailNotification;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_PutContainerOnHold")]
    protected Info _PutContainerOnHold;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_EMailMessage")]
    protected Info _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_SPCChartDisplayOption")]
    protected Info _SPCChartDisplayOption;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_UserParm5")]
    protected Info _UserParm5;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_RunTimeDisplay")]
    protected Info _RunTimeDisplay;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_UserParm3")]
    protected Info _UserParm3;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_RequireAnnotation")]
    protected Info _RequireAnnotation;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_DisplayOnException")]
    protected Info _DisplayOnException;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_ChartHeight")]
    protected Info _ChartHeight;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_UserParm6")]
    protected Info _UserParm6;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_UserParm8")]
    protected Info _UserParm8;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_UserParm9")]
    protected Info _UserParm9;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_TriggerOCAPs")]
    protected Info _TriggerOCAPs;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_UserParm4")]
    protected Info _UserParm4;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_RecordAgainstCustomSPCDataSrc")]
    protected Info _RecordAgainstCustomSPCDataSrc;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_ChartType")]
    protected Info _ChartType;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_UserParm10")]
    protected Info _UserParm10;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_UserParm1")]
    protected Info _UserParm1;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_UserParm7")]
    protected Info _UserParm7;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_ChartWidth")]
    protected Info _ChartWidth;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_UserParm2")]
    protected Info _UserParm2;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_ChartVariable")]
    protected Info _ChartVariable;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_SetResourceStatus")]
    protected Info _SetResourceStatus;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_DocToView")]
    protected Info _DocToView;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_ChartProperties")]
    protected Info _ChartProperties;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Info_Macro")]
    protected Info _Macro;

    public Info EmailNotification
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmailNotification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmailNotification));
      }
    }

    public Info PutContainerOnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (PutContainerOnHold), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PutContainerOnHold));
      }
    }

    public Info EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public Info SPCChartDisplayOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDisplayOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SPCChartDisplayOption));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info UserParm5
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm5), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserParm5));
      }
    }

    public Info RunTimeDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (RunTimeDisplay), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RunTimeDisplay));
      }
    }

    public Info UserParm3
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm3), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserParm3));
      }
    }

    public Info RequireAnnotation
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequireAnnotation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequireAnnotation));
      }
    }

    public Info DisplayOnException
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayOnException), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayOnException));
      }
    }

    public Info ChartHeight
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartHeight), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChartHeight));
      }
    }

    public Info UserParm6
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm6), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserParm6));
      }
    }

    public Info UserParm8
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm8), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserParm8));
      }
    }

    public Info UserParm9
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm9), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserParm9));
      }
    }

    public Info TriggerOCAPs
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriggerOCAPs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriggerOCAPs));
      }
    }

    public Info UserParm4
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm4), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserParm4));
      }
    }

    public Info RecordAgainstCustomSPCDataSrc
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAgainstCustomSPCDataSrc), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecordAgainstCustomSPCDataSrc));
      }
    }

    public Info ChartType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChartType));
      }
    }

    public Info UserParm10
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm10), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserParm10));
      }
    }

    public Info UserParm1
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm1), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserParm1));
      }
    }

    public Info UserParm7
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm7), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserParm7));
      }
    }

    public Info ChartWidth
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartWidth), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChartWidth));
      }
    }

    public Info UserParm2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserParm2));
      }
    }

    public Info ChartVariable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartVariable), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChartVariable));
      }
    }

    public Info SetResourceStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetResourceStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SetResourceStatus));
      }
    }

    public Info DocToView
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocToView), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocToView));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info ChartProperties
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartProperties), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChartProperties));
      }
    }

    public Info Macro
    {
      [param: In] set
      {
        this.PropertySet(nameof (Macro), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Macro));
      }
    }
  }
}
