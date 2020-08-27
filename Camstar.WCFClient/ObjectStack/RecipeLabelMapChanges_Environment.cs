// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeLabelMapChanges_Environment
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
  public class RecipeLabelMapChanges_Environment : LabelTxnMapChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeLabelMapChanges_Environment_ObjectToChange")]
    [Metadata("Contains a match between a Recipe List and a label definition to be printed.", "RecipeLabelMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Contains a match between a Recipe List and a label definition to be printed.", "RecipeLabelMapChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeLabelMapChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeLabelMapChanges_Environment_TxnType")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1048909, false, false, true, null)]
    protected new Environment _TxnType;

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

    public new Environment TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnType));
      }
    }
  }
}
