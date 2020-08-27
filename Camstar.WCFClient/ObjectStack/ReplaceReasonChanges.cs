// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReplaceReasonChanges
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
  public class ReplaceReasonChanges : UserCodeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ReplaceReasonChanges_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "ReplaceReasonChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ReplaceReasonChanges_IsScrapRemoved")]
    protected Primitive<bool> _IsScrapRemoved;
    [DataMember(EmitDefaultValue = false, Name = "ReplaceReasonChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ReplaceReasonChanges && object.Equals((object) this._FilterTags, (object) ((ReplaceReasonChanges) obj)._FilterTags) && (object.Equals((object) this._ObjectToChange, (object) ((ReplaceReasonChanges) obj)._ObjectToChange) && object.Equals((object) this._IsScrapRemoved, (object) ((ReplaceReasonChanges) obj)._IsScrapRemoved)) && object.Equals((object) this._Name, (object) ((ReplaceReasonChanges) obj)._Name) && base.Equals(obj);
    }

    public new Primitive<string> FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilterTags));
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

    public Primitive<bool> IsScrapRemoved
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsScrapRemoved), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsScrapRemoved));
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
