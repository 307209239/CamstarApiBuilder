// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Split_Info
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
  public class Split_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Split_Info_ToContainerDetails")]
    protected SplitDetails_Info _ToContainerDetails;
    [DataMember(EmitDefaultValue = false, Name = "Split_Info_AutoNumberRule")]
    protected Info _AutoNumberRule;
    [DataMember(EmitDefaultValue = false, Name = "Split_Info_AutoNumber")]
    protected Info _AutoNumber;
    [DataMember(EmitDefaultValue = false, Name = "Split_Info_CloseWhenEmpty")]
    protected Info _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "Split_Info_ChildContainers")]
    protected Info _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "Split_Info_AllowZeroQtys")]
    protected Info _AllowZeroQtys;
    [DataMember(EmitDefaultValue = false, Name = "Split_Info_ToContainerName")]
    protected Info _ToContainerName;
    [DataMember(EmitDefaultValue = false, Name = "Split_Info_Documents")]
    protected Info _Documents;

    public SplitDetails_Info ToContainerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerDetails), (object) value);
      }
      get
      {
        return (SplitDetails_Info) this.PropertyGet(nameof (ToContainerDetails));
      }
    }

    public Info AutoNumberRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumberRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoNumberRule));
      }
    }

    public Info AutoNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoNumber));
      }
    }

    public Info CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public Info ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Info AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }

    public Info ToContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToContainerName));
      }
    }

    public Info Documents
    {
      [param: In] set
      {
        this.PropertySet(nameof (Documents), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Documents));
      }
    }
  }
}
