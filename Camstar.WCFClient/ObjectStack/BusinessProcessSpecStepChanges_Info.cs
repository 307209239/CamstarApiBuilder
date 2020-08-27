// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessProcessSpecStepChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChangeMgtSpecStepChanges_Info))]
  [Serializable]
  public class BusinessProcessSpecStepChanges_Info : StepChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Info_Sequence")]
    protected new Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Info_OnDefaultRoute")]
    protected new Info _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Info_StepType")]
    protected new Info _StepType;

    public new Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
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

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public new Info OnDefaultRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnDefaultRoute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OnDefaultRoute));
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

    public new Info StepType
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StepType));
      }
    }
  }
}
