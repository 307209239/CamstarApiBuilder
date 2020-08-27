// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCChartDefChanges
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
  public class SPCChartDefChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_EmailNotification")]
    protected Primitive<string> _EmailNotification;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_PutContainerOnHold")]
    protected NamedObjectRef _PutContainerOnHold;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_EMailMessage")]
    protected NamedObjectRef _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_SPCChartDisplayOption")]
    protected Enumeration<SPCChartDisplayOptionEnum, int> _SPCChartDisplayOption;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_UserParm5")]
    protected Primitive<string> _UserParm5;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_RunTimeDisplay")]
    protected Primitive<bool> _RunTimeDisplay;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_UserParm3")]
    protected Primitive<string> _UserParm3;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_RequireAnnotation")]
    protected Primitive<bool> _RequireAnnotation;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_DisplayOnException")]
    protected Primitive<bool> _DisplayOnException;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_ChartHeight")]
    protected Primitive<int> _ChartHeight;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_UserParm6")]
    protected Primitive<string> _UserParm6;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_UserParm8")]
    protected Primitive<string> _UserParm8;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_UserParm9")]
    protected Primitive<string> _UserParm9;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_TriggerOCAPs")]
    protected Primitive<bool> _TriggerOCAPs;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_UserParm4")]
    protected Primitive<string> _UserParm4;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_RecordAgainstCustomSPCDataSrc")]
    protected Primitive<bool> _RecordAgainstCustomSPCDataSrc;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_ChartType")]
    protected Primitive<string> _ChartType;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_UserParm10")]
    protected Primitive<string> _UserParm10;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_UserParm1")]
    protected Primitive<string> _UserParm1;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_UserParm7")]
    protected Primitive<string> _UserParm7;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_ChartWidth")]
    protected Primitive<int> _ChartWidth;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_UserParm2")]
    protected Primitive<string> _UserParm2;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_ChartVariable")]
    protected Primitive<string> _ChartVariable;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_SetResourceStatus")]
    protected NamedObjectRef _SetResourceStatus;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_DocToView")]
    protected RevisionedObjectRef _DocToView;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_ChartProperties")]
    protected Primitive<string> _ChartProperties;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefChanges_Macro")]
    protected Primitive<string> _Macro;

    public override bool Equals(object obj)
    {
      return obj is SPCChartDefChanges && object.Equals((object) this._EmailNotification, (object) ((SPCChartDefChanges) obj)._EmailNotification) && (object.Equals((object) this._PutContainerOnHold, (object) ((SPCChartDefChanges) obj)._PutContainerOnHold) && object.Equals((object) this._EMailMessage, (object) ((SPCChartDefChanges) obj)._EMailMessage)) && (object.Equals((object) this._SPCChartDisplayOption, (object) ((SPCChartDefChanges) obj)._SPCChartDisplayOption) && object.Equals((object) this._ObjectToChange, (object) ((SPCChartDefChanges) obj)._ObjectToChange) && (object.Equals((object) this._UserParm5, (object) ((SPCChartDefChanges) obj)._UserParm5) && object.Equals((object) this._RunTimeDisplay, (object) ((SPCChartDefChanges) obj)._RunTimeDisplay))) && (object.Equals((object) this._UserParm3, (object) ((SPCChartDefChanges) obj)._UserParm3) && object.Equals((object) this._RequireAnnotation, (object) ((SPCChartDefChanges) obj)._RequireAnnotation) && (object.Equals((object) this._DisplayOnException, (object) ((SPCChartDefChanges) obj)._DisplayOnException) && object.Equals((object) this._ChartHeight, (object) ((SPCChartDefChanges) obj)._ChartHeight)) && (object.Equals((object) this._UserParm6, (object) ((SPCChartDefChanges) obj)._UserParm6) && object.Equals((object) this._UserParm8, (object) ((SPCChartDefChanges) obj)._UserParm8) && (object.Equals((object) this._UserParm9, (object) ((SPCChartDefChanges) obj)._UserParm9) && object.Equals((object) this._TriggerOCAPs, (object) ((SPCChartDefChanges) obj)._TriggerOCAPs)))) && (object.Equals((object) this._UserParm4, (object) ((SPCChartDefChanges) obj)._UserParm4) && object.Equals((object) this._RecordAgainstCustomSPCDataSrc, (object) ((SPCChartDefChanges) obj)._RecordAgainstCustomSPCDataSrc) && (object.Equals((object) this._ChartType, (object) ((SPCChartDefChanges) obj)._ChartType) && object.Equals((object) this._UserParm10, (object) ((SPCChartDefChanges) obj)._UserParm10)) && (object.Equals((object) this._UserParm1, (object) ((SPCChartDefChanges) obj)._UserParm1) && object.Equals((object) this._UserParm7, (object) ((SPCChartDefChanges) obj)._UserParm7) && (object.Equals((object) this._ChartWidth, (object) ((SPCChartDefChanges) obj)._ChartWidth) && object.Equals((object) this._UserParm2, (object) ((SPCChartDefChanges) obj)._UserParm2))) && (object.Equals((object) this._ChartVariable, (object) ((SPCChartDefChanges) obj)._ChartVariable) && object.Equals((object) this._SetResourceStatus, (object) ((SPCChartDefChanges) obj)._SetResourceStatus) && (object.Equals((object) this._DocToView, (object) ((SPCChartDefChanges) obj)._DocToView) && object.Equals((object) this._Name, (object) ((SPCChartDefChanges) obj)._Name)) && (object.Equals((object) this._ChartProperties, (object) ((SPCChartDefChanges) obj)._ChartProperties) && object.Equals((object) this._Macro, (object) ((SPCChartDefChanges) obj)._Macro)))) && base.Equals(obj);
    }

    public Primitive<string> EmailNotification
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmailNotification), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EmailNotification));
      }
    }

    public NamedObjectRef PutContainerOnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (PutContainerOnHold), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PutContainerOnHold));
      }
    }

    public NamedObjectRef EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public Enumeration<SPCChartDisplayOptionEnum, int> SPCChartDisplayOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDisplayOption), (object) value);
      }
      get
      {
        return (Enumeration<SPCChartDisplayOptionEnum, int>) this.PropertyGet(nameof (SPCChartDisplayOption));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<string> UserParm5
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm5), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserParm5));
      }
    }

    public Primitive<bool> RunTimeDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (RunTimeDisplay), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RunTimeDisplay));
      }
    }

    public Primitive<string> UserParm3
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm3), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserParm3));
      }
    }

    public Primitive<bool> RequireAnnotation
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequireAnnotation), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RequireAnnotation));
      }
    }

    public Primitive<bool> DisplayOnException
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayOnException), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisplayOnException));
      }
    }

    public Primitive<int> ChartHeight
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartHeight), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChartHeight));
      }
    }

    public Primitive<string> UserParm6
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm6), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserParm6));
      }
    }

    public Primitive<string> UserParm8
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm8), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserParm8));
      }
    }

    public Primitive<string> UserParm9
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm9), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserParm9));
      }
    }

    public Primitive<bool> TriggerOCAPs
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriggerOCAPs), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TriggerOCAPs));
      }
    }

    public Primitive<string> UserParm4
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm4), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserParm4));
      }
    }

    public Primitive<bool> RecordAgainstCustomSPCDataSrc
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAgainstCustomSPCDataSrc), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RecordAgainstCustomSPCDataSrc));
      }
    }

    public Primitive<string> ChartType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChartType));
      }
    }

    public Primitive<string> UserParm10
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm10), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserParm10));
      }
    }

    public Primitive<string> UserParm1
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm1), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserParm1));
      }
    }

    public Primitive<string> UserParm7
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm7), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserParm7));
      }
    }

    public Primitive<int> ChartWidth
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartWidth), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChartWidth));
      }
    }

    public Primitive<string> UserParm2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserParm2), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserParm2));
      }
    }

    public Primitive<string> ChartVariable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartVariable), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChartVariable));
      }
    }

    public NamedObjectRef SetResourceStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetResourceStatus), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SetResourceStatus));
      }
    }

    public RevisionedObjectRef DocToView
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocToView), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DocToView));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<string> ChartProperties
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartProperties), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChartProperties));
      }
    }

    public Primitive<string> Macro
    {
      [param: In] set
      {
        this.PropertySet(nameof (Macro), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Macro));
      }
    }
  }
}
