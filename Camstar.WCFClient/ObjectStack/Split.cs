// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Split
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
  public class Split : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "Split_ToContainerDetails")]
    protected SplitDetails[] _ToContainerDetails;
    [DataMember(EmitDefaultValue = false, Name = "Split_AutoNumberRule")]
    protected NamedObjectRef _AutoNumberRule;
    [DataMember(EmitDefaultValue = false, Name = "Split_AutoNumber")]
    protected Primitive<bool> _AutoNumber;
    [DataMember(EmitDefaultValue = false, Name = "Split_CloseWhenEmpty")]
    protected Primitive<bool> _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "Split_ChildContainers")]
    protected ContainerRef[] _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "Split_AllowZeroQtys")]
    protected Primitive<bool> _AllowZeroQtys;
    [DataMember(EmitDefaultValue = false, Name = "Split_ToContainerName")]
    protected Primitive<string> _ToContainerName;
    [DataMember(EmitDefaultValue = false, Name = "Split_Documents")]
    protected NamedSubentityRef[] _Documents;

    public override bool Equals(object obj)
    {
      return obj is Split && this.CompareArrays((Array) this._ToContainerDetails, (Array) ((Split) obj)._ToContainerDetails) && (object.Equals((object) this._AutoNumberRule, (object) ((Split) obj)._AutoNumberRule) && object.Equals((object) this._AutoNumber, (object) ((Split) obj)._AutoNumber)) && (object.Equals((object) this._CloseWhenEmpty, (object) ((Split) obj)._CloseWhenEmpty) && this.CompareArrays((Array) this._ChildContainers, (Array) ((Split) obj)._ChildContainers) && (object.Equals((object) this._AllowZeroQtys, (object) ((Split) obj)._AllowZeroQtys) && object.Equals((object) this._ToContainerName, (object) ((Split) obj)._ToContainerName))) && this.CompareArrays((Array) this._Documents, (Array) ((Split) obj)._Documents) && base.Equals(obj);
    }

    public SplitDetails[] ToContainerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerDetails), (object) value);
      }
      get
      {
        return (SplitDetails[]) this.PropertyGet(nameof (ToContainerDetails));
      }
    }

    public NamedObjectRef AutoNumberRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumberRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AutoNumberRule));
      }
    }

    public Primitive<bool> AutoNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumber), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoNumber));
      }
    }

    public Primitive<bool> CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public ContainerRef[] ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Primitive<bool> AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }

    public Primitive<string> ToContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ToContainerName));
      }
    }

    public NamedSubentityRef[] Documents
    {
      [param: In] set
      {
        this.PropertySet(nameof (Documents), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (Documents));
      }
    }
  }
}
