// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_CDOInquiry_Info
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
  public class V4_CDOInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Info_CDODefName")]
    protected Info _CDODefName;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Info_CDOInstances")]
    protected Info _CDOInstances;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Info_CDODefID")]
    protected Info _CDODefID;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Info_IsInstanceType")]
    protected Info _IsInstanceType;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Info_NameList")]
    protected Info _NameList;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Info_IsFieldInquiry")]
    protected Info _IsFieldInquiry;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Info_Length")]
    protected Info _Length;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Info_CDOTypes")]
    protected Info _CDOTypes;

    public Info CDODefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CDODefName));
      }
    }

    public Info CDOInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOInstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CDOInstances));
      }
    }

    public Info CDODefID
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CDODefID));
      }
    }

    public Info IsInstanceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsInstanceType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsInstanceType));
      }
    }

    public Info NameList
    {
      [param: In] set
      {
        this.PropertySet(nameof (NameList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NameList));
      }
    }

    public Info IsFieldInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFieldInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFieldInquiry));
      }
    }

    public Info Length
    {
      [param: In] set
      {
        this.PropertySet(nameof (Length), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Length));
      }
    }

    public Info CDOTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CDOTypes));
      }
    }
  }
}
