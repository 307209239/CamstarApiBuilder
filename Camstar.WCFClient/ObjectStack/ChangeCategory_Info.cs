// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeCategory_Info
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
  public class ChangeCategory_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategory_Info_NewCategory")]
    protected Info _NewCategory;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategory_Info_FromCategory")]
    protected Info _FromCategory;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategory_Info_TriageComplete")]
    protected Info _TriageComplete;

    public Info NewCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewCategory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewCategory));
      }
    }

    public Info FromCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCategory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromCategory));
      }
    }

    public Info TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageComplete));
      }
    }
  }
}
