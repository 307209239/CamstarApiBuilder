// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IOccupationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IOccupationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      OccupationMaint occupationMaint,
      OccupationMaint_LoadESigDetails_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      OccupationMaintMethod[] methods,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      OccupationMaint occupationMaint,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      OccupationMaint occupationMaint,
      OccupationMaint_Request request,
      out OccupationMaint_Result result);
  }
}
