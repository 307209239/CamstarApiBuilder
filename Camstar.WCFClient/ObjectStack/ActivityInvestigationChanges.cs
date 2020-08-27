// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityInvestigationChanges
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
  public class ActivityInvestigationChanges : ActivityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationChanges_Failures")]
    protected FailureDataChanges[] _Failures;
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActivityInvestigationChanges && this.CompareArrays((Array) this._Failures, (Array) ((ActivityInvestigationChanges) obj)._Failures) && (object.Equals((object) this._ListItemToChange, (object) ((ActivityInvestigationChanges) obj)._ListItemToChange) && object.Equals((object) this._ObjectToChange, (object) ((ActivityInvestigationChanges) obj)._ObjectToChange)) && object.Equals((object) this._Name, (object) ((ActivityInvestigationChanges) obj)._Name) && base.Equals(obj);
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

    public new NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
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
