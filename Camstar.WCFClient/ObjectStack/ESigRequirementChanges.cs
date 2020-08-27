// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigRequirementChanges
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
  public class ESigRequirementChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigRequirementChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ESigRequirementChanges_ESigReqDetails")]
    protected ESigReqDetailChanges[] _ESigReqDetails;
    [DataMember(EmitDefaultValue = false, Name = "ESigRequirementChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ESigRequirementChanges && object.Equals((object) this._ObjectToChange, (object) ((ESigRequirementChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._ESigReqDetails, (Array) ((ESigRequirementChanges) obj)._ESigReqDetails) && object.Equals((object) this._Name, (object) ((ESigRequirementChanges) obj)._Name)) && base.Equals(obj);
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

    public ESigReqDetailChanges[] ESigReqDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigReqDetails), (object) value);
      }
      get
      {
        return (ESigReqDetailChanges[]) this.PropertyGet(nameof (ESigReqDetails));
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
