// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AQLLevelChanges
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
  public class AQLLevelChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "AQLLevelChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "AQLLevelChanges_SampleSizeDetails")]
    protected SampleSizeDetailsChanges[] _SampleSizeDetails;
    [DataMember(EmitDefaultValue = false, Name = "AQLLevelChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is AQLLevelChanges && object.Equals((object) this._ObjectToChange, (object) ((AQLLevelChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._SampleSizeDetails, (Array) ((AQLLevelChanges) obj)._SampleSizeDetails) && object.Equals((object) this._Name, (object) ((AQLLevelChanges) obj)._Name)) && base.Equals(obj);
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

    public SampleSizeDetailsChanges[] SampleSizeDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleSizeDetails), (object) value);
      }
      get
      {
        return (SampleSizeDetailsChanges[]) this.PropertyGet(nameof (SampleSizeDetails));
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
