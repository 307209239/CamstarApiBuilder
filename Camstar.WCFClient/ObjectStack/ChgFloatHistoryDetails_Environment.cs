// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFloatHistoryDetails_Environment
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
  public class ChgFloatHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatHistoryDetails_Environment_OldFloatValue")]
    [Metadata("Generic Float", "", false, false, true, "Float", 1049745, false, false, false, null)]
    protected Environment _OldFloatValue;
    [Metadata("Generic Float", "", false, false, true, "Float", 1049744, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatHistoryDetails_Environment_NewFloatValue")]
    protected Environment _NewFloatValue;

    public Environment OldFloatValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFloatValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldFloatValue));
      }
    }

    public Environment NewFloatValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFloatValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewFloatValue));
      }
    }
  }
}
