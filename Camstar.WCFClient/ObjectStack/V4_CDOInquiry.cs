// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_CDOInquiry
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
  public class V4_CDOInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_CDODefName")]
    protected Primitive<string> _CDODefName;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_CDOInstances")]
    protected BaseObjectRef[] _CDOInstances;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_CDODefID")]
    protected Primitive<int> _CDODefID;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_IsInstanceType")]
    protected Primitive<bool> _IsInstanceType;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_NameList")]
    protected Primitive<string>[] _NameList;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_IsFieldInquiry")]
    protected Primitive<bool> _IsFieldInquiry;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Length")]
    protected Primitive<int> _Length;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_CDOTypes")]
    protected Primitive<int>[] _CDOTypes;

    public override bool Equals(object obj)
    {
      return obj is V4_CDOInquiry && object.Equals((object) this._CDODefName, (object) ((V4_CDOInquiry) obj)._CDODefName) && (this.CompareArrays((Array) this._CDOInstances, (Array) ((V4_CDOInquiry) obj)._CDOInstances) && object.Equals((object) this._CDODefID, (object) ((V4_CDOInquiry) obj)._CDODefID)) && (object.Equals((object) this._IsInstanceType, (object) ((V4_CDOInquiry) obj)._IsInstanceType) && this.CompareArrays((Array) this._NameList, (Array) ((V4_CDOInquiry) obj)._NameList) && (object.Equals((object) this._IsFieldInquiry, (object) ((V4_CDOInquiry) obj)._IsFieldInquiry) && object.Equals((object) this._Length, (object) ((V4_CDOInquiry) obj)._Length))) && this.CompareArrays((Array) this._CDOTypes, (Array) ((V4_CDOInquiry) obj)._CDOTypes) && base.Equals(obj);
    }

    public Primitive<string> CDODefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CDODefName));
      }
    }

    public BaseObjectRef[] CDOInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOInstances), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (CDOInstances));
      }
    }

    public Primitive<int> CDODefID
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefID), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CDODefID));
      }
    }

    public Primitive<bool> IsInstanceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsInstanceType), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsInstanceType));
      }
    }

    public Primitive<string>[] NameList
    {
      [param: In] set
      {
        this.PropertySet(nameof (NameList), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (NameList));
      }
    }

    public Primitive<bool> IsFieldInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFieldInquiry), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFieldInquiry));
      }
    }

    public Primitive<int> Length
    {
      [param: In] set
      {
        this.PropertySet(nameof (Length), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Length));
      }
    }

    public Primitive<int>[] CDOTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOTypes), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (CDOTypes));
      }
    }
  }
}
