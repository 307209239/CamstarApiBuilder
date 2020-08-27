// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductionProcessDetailChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (EProcedureDetailChanges))]
  [KnownType(typeof (MasterRecipeDetailChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ProductionProcessDetailChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessDetailChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessDetailChanges_TaskList")]
    protected RevisionedObjectRef _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessDetailChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessDetailChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ProductionProcessDetailChanges && object.Equals((object) this._Sequence, (object) ((ProductionProcessDetailChanges) obj)._Sequence) && (object.Equals((object) this._TaskList, (object) ((ProductionProcessDetailChanges) obj)._TaskList) && object.Equals((object) this._ListItemToChange, (object) ((ProductionProcessDetailChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ObjectToChange, (object) ((ProductionProcessDetailChanges) obj)._ObjectToChange) && object.Equals((object) this._IsFrozen, (object) ((ProductionProcessDetailChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public RevisionedObjectRef TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TaskList));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
