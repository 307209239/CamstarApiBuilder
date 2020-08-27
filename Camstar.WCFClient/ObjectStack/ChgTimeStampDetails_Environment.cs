// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgTimeStampDetails_Environment
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
  public class ChgTimeStampDetails_Environment : ChangeAttributeDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampDetails_Environment_NewValue")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049143, false, false, false, null)]
    protected Environment _NewValue;

    public Environment NewValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewValue));
      }
    }
  }
}
