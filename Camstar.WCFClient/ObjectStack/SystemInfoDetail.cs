// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SystemInfoDetail
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
  public class SystemInfoDetail : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoDetail_InfoName")]
    protected Primitive<string> _InfoName;
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoDetail_InfoSource")]
    protected Primitive<string> _InfoSource;
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoDetail_InfoValue")]
    protected Primitive<string> _InfoValue;

    public override bool Equals(object obj)
    {
      return obj is SystemInfoDetail && object.Equals((object) this._InfoName, (object) ((SystemInfoDetail) obj)._InfoName) && (object.Equals((object) this._InfoSource, (object) ((SystemInfoDetail) obj)._InfoSource) && object.Equals((object) this._InfoValue, (object) ((SystemInfoDetail) obj)._InfoValue)) && base.Equals(obj);
    }

    public Primitive<string> InfoName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InfoName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InfoName));
      }
    }

    public Primitive<string> InfoSource
    {
      [param: In] set
      {
        this.PropertySet(nameof (InfoSource), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InfoSource));
      }
    }

    public Primitive<string> InfoValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (InfoValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InfoValue));
      }
    }
  }
}
