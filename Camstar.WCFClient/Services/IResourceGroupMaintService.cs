// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_LoadESigDetails_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceGroupMaintMethod[] methods,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result);
  }
}
