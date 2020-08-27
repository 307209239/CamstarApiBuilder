// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TransactionItemChanges_Info
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
  public class TransactionItemChanges_Info : TaskItemChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TransactionItemChanges_Info_TransactionPage")]
    protected Info _TransactionPage;
    [DataMember(EmitDefaultValue = false, Name = "TransactionItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TransactionItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;

    public Info TransactionPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionPage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TransactionPage));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
