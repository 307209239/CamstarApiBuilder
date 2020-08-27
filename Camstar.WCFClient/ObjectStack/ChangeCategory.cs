// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeCategory
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
  public class ChangeCategory : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategory_NewCategory")]
    protected Enumeration<CategoryEnum, int> _NewCategory;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategory_FromCategory")]
    protected Enumeration<CategoryEnum, int> _FromCategory;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategory_TriageComplete")]
    protected Primitive<bool> _TriageComplete;

    public override bool Equals(object obj)
    {
      return obj is ChangeCategory && object.Equals((object) this._NewCategory, (object) ((ChangeCategory) obj)._NewCategory) && (object.Equals((object) this._FromCategory, (object) ((ChangeCategory) obj)._FromCategory) && object.Equals((object) this._TriageComplete, (object) ((ChangeCategory) obj)._TriageComplete)) && base.Equals(obj);
    }

    public Enumeration<CategoryEnum, int> NewCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewCategory), (object) value);
      }
      get
      {
        return (Enumeration<CategoryEnum, int>) this.PropertyGet(nameof (NewCategory));
      }
    }

    public Enumeration<CategoryEnum, int> FromCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCategory), (object) value);
      }
      get
      {
        return (Enumeration<CategoryEnum, int>) this.PropertyGet(nameof (FromCategory));
      }
    }

    public Primitive<bool> TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TriageComplete));
      }
    }
  }
}
