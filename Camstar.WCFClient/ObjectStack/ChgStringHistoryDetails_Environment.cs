// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgStringHistoryDetails_Environment
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
  public class ChgStringHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, true, "String", 1049756, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgStringHistoryDetails_Environment_NewStringValue")]
    protected Environment _NewStringValue;
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, true, "String", 1049757, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgStringHistoryDetails_Environment_OldStringValue")]
    protected Environment _OldStringValue;

    public Environment NewStringValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewStringValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewStringValue));
      }
    }

    public Environment OldStringValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldStringValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldStringValue));
      }
    }
  }
}
