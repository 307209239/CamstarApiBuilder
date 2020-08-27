// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelDetails_Environment
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
  public class LabelDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelDetails_Environment_TagValue")]
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, false, "String", 1050621, false, false, false, null)]
    protected Environment _TagValue;
    [Metadata("Generic String", "", false, false, false, "String", 1050620, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelDetails_Environment_TagName")]
    protected Environment _TagName;

    public Environment TagValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TagValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TagValue));
      }
    }

    public Environment TagName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TagName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TagName));
      }
    }
  }
}
