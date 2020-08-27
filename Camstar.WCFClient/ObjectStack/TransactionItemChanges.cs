// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TransactionItemChanges
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
  public class TransactionItemChanges : TaskItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TransactionItemChanges_TransactionPage")]
    protected NamedObjectRef _TransactionPage;
    [DataMember(EmitDefaultValue = false, Name = "TransactionItemChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TransactionItemChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is TransactionItemChanges && object.Equals((object) this._TransactionPage, (object) ((TransactionItemChanges) obj)._TransactionPage) && (object.Equals((object) this._ListItemToChange, (object) ((TransactionItemChanges) obj)._ListItemToChange) && object.Equals((object) this._ObjectToChange, (object) ((TransactionItemChanges) obj)._ObjectToChange)) && base.Equals(obj);
    }

    public NamedObjectRef TransactionPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionPage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TransactionPage));
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
  }
}
