// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPackageTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPackageTypeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_LoadESigDetails_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PackageTypeMaintMethod[] methods,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result);
  }
}
