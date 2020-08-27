// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IFilterTagMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IFilterTagMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      FilterTagMaint filterTagMaint,
      FilterTagMaint_LoadESigDetails_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      FilterTagMaintMethod[] methods,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result);
  }
}
