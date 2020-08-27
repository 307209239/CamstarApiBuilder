// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgStringListHistoryDetails_Environment
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
  public class ChgStringListHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, true, "String", 1049758, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgStringListHistoryDetails_Environment_NewStringListValue")]
    protected Environment _NewStringListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgStringListHistoryDetails_Environment_OldStringListValue")]
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, true, "String", 1049759, false, true, false, null)]
    protected Environment _OldStringListValue;

    public Environment NewStringListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewStringListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewStringListValue));
      }
    }

    public Environment OldStringListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldStringListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldStringListValue));
      }
    }
  }
}
