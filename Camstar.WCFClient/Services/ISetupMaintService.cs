// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISetupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISetupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_LoadESigDetails_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SetupMaintMethod[] methods,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result);
  }
}
