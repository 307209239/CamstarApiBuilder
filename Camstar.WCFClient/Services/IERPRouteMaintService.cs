// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IERPRouteMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IERPRouteMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_LoadESigDetails_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ERPRouteMaintMethod[] methods,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result);
  }
}
