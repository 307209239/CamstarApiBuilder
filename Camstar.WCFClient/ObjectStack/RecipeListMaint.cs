// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeListMaint
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
  public class RecipeListMaint : ProcessListMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeListMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListMaint_ObjectChanges")]
    protected RecipeListChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is RecipeListMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((RecipeListMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._BaseToChange, (object) ((RecipeListMaint) obj)._BaseToChange) && object.Equals((object) this._ObjectChanges, (object) ((RecipeListMaint) obj)._ObjectChanges)) && object.Equals((object) this._ObjectToChange, (object) ((RecipeListMaint) obj)._ObjectToChange) && base.Equals(obj);
    }

    public new RevisionedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new RevisionedObjectRef BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public RecipeListChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RecipeListChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
