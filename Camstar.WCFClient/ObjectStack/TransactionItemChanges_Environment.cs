// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TransactionItemChanges_Environment
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
  public class TransactionItemChanges_Environment : TaskItemChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TransactionItemChanges_Environment_TransactionPage")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, true, false, "NamedObjectRef", 1052649, false, false, true, null)]
    protected Environment _TransactionPage;
    [DataMember(EmitDefaultValue = false, Name = "TransactionItemChanges_Environment_ListItemToChange")]
    [Metadata("Transaction Task allows the user to define a task for completing a shop floor transaction.", "TransactionItemChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Transaction Task allows the user to define a task for completing a shop floor transaction.", "TransactionItem", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TransactionItemChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public Environment TransactionPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionPage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TransactionPage));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
