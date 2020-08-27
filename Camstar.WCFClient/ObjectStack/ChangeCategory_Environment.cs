// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeCategory_Environment
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
  public class ChangeCategory_Environment : QualityTxn_Environment
  {
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, false, false, "Integer", 1051206, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategory_Environment_NewCategory")]
    protected Environment _NewCategory;
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, false, true, "Integer", 1051427, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategory_Environment_FromCategory")]
    protected Environment _FromCategory;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051655, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategory_Environment_TriageComplete")]
    protected Environment _TriageComplete;

    public Environment NewCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewCategory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewCategory));
      }
    }

    public Environment FromCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCategory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromCategory));
      }
    }

    public Environment TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriageComplete));
      }
    }
  }
}
