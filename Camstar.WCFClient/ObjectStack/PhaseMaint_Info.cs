﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseMaint_Info
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
  public class PhaseMaint_Info : ProcessObjectMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseMaint_Info_Template")]
    protected new Info _Template;
    [DataMember(EmitDefaultValue = false, Name = "PhaseMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PhaseMaint_Info_ObjectChanges")]
    protected PhaseChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PhaseMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PhaseMaint_Info_ValidChildTypes")]
    protected new Info _ValidChildTypes;

    public new Info Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Template));
      }
    }

    public new Info ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public PhaseChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PhaseChanges_Info) this.PropertyGet(nameof (ObjectChanges));
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

    public new Info ValidChildTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidChildTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ValidChildTypes));
      }
    }
  }
}
