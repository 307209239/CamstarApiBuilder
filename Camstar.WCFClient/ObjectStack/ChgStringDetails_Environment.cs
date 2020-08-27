// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgStringDetails_Environment
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
  public class ChgStringDetails_Environment : ChangeAttributeDetails_Environment
  {
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, false, "String", 1049141, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgStringDetails_Environment_NewValue")]
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
