// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductMaint
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
  public class ProductMaint : RevisionedObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductMaint_ObjectChanges")]
    protected ProductChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProductMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;

    public override bool Equals(object obj)
    {
      return obj is ProductMaint && object.Equals((object) this._ObjectChanges, (object) ((ProductMaint) obj)._ObjectChanges) && (object.Equals((object) this._ObjectToChange, (object) ((ProductMaint) obj)._ObjectToChange) && object.Equals((object) this._BaseToChange, (object) ((ProductMaint) obj)._BaseToChange)) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ProductMaint) obj)._ObjectListInquiry) && base.Equals(obj);
    }

    public ProductChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProductChanges) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
