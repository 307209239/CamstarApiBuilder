// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityInvestigation
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
  public class ActivityInvestigation : Activity
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigation_NewProcessObjects")]
    protected NamedSubentityRef[] _NewProcessObjects;
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigation_Failures")]
    protected FailureData[] _Failures;
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigation_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActivityInvestigation && this.CompareArrays((Array) this._NewProcessObjects, (Array) ((ActivityInvestigation) obj)._NewProcessObjects) && (this.CompareArrays((Array) this._Failures, (Array) ((ActivityInvestigation) obj)._Failures) && object.Equals((object) this._Name, (object) ((ActivityInvestigation) obj)._Name)) && base.Equals(obj);
    }

    public NamedSubentityRef[] NewProcessObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewProcessObjects), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (NewProcessObjects));
      }
    }

    public FailureData[] Failures
    {
      [param: In] set
      {
        this.PropertySet(nameof (Failures), (object) value);
      }
      get
      {
        return (FailureData[]) this.PropertyGet(nameof (Failures));
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
