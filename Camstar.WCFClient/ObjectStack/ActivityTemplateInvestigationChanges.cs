// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateInvestigationChanges
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
  public class ActivityTemplateInvestigationChanges : ActivityTemplateChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationChanges_Failures")]
    protected FailureDataChanges[] _Failures;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActivityTemplateInvestigationChanges && object.Equals((object) this._ObjectToChange, (object) ((ActivityTemplateInvestigationChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._Failures, (Array) ((ActivityTemplateInvestigationChanges) obj)._Failures) && object.Equals((object) this._Name, (object) ((ActivityTemplateInvestigationChanges) obj)._Name)) && base.Equals(obj);
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

    public FailureDataChanges[] Failures
    {
      [param: In] set
      {
        this.PropertySet(nameof (Failures), (object) value);
      }
      get
      {
        return (FailureDataChanges[]) this.PropertyGet(nameof (Failures));
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
