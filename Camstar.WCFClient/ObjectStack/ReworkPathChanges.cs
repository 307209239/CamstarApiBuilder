// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkPathChanges
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
  public class ReworkPathChanges : PathChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_EndReworkStep")]
    protected NamedSubentityRef _EndReworkStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_ReEntryStep")]
    protected NamedSubentityRef _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_Steps")]
    protected StepChanges[] _Steps;
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ReworkPathChanges && object.Equals((object) this._EndReworkStep, (object) ((ReworkPathChanges) obj)._EndReworkStep) && (object.Equals((object) this._ReEntryStep, (object) ((ReworkPathChanges) obj)._ReEntryStep) && this.CompareArrays((Array) this._Steps, (Array) ((ReworkPathChanges) obj)._Steps)) && object.Equals((object) this._Name, (object) ((ReworkPathChanges) obj)._Name) && base.Equals(obj);
    }

    public NamedSubentityRef EndReworkStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (EndReworkStep));
      }
    }

    public NamedSubentityRef ReEntryStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ReEntryStep));
      }
    }

    public StepChanges[] Steps
    {
      [param: In] set
      {
        this.PropertySet(nameof (Steps), (object) value);
      }
      get
      {
        return (StepChanges[]) this.PropertyGet(nameof (Steps));
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
  }
}
