// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgStringHistoryDetails
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
  public class ChgStringHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgStringHistoryDetails_NewStringValue")]
    protected Primitive<string> _NewStringValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgStringHistoryDetails_OldStringValue")]
    protected Primitive<string> _OldStringValue;

    public override bool Equals(object obj)
    {
      return obj is ChgStringHistoryDetails && object.Equals((object) this._NewStringValue, (object) ((ChgStringHistoryDetails) obj)._NewStringValue) && object.Equals((object) this._OldStringValue, (object) ((ChgStringHistoryDetails) obj)._OldStringValue) && base.Equals(obj);
    }

    public Primitive<string> NewStringValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewStringValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NewStringValue));
      }
    }

    public Primitive<string> OldStringValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldStringValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OldStringValue));
      }
    }
  }
}
