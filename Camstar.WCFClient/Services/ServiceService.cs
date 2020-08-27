// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ServiceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ServiceService : WCFService
  {
    public ServiceService(UserProfile userProfile)
    {
      this.Initialize(typeof (IServiceService), userProfile);
    }

    public ResultStatus AfterCommitEventFailure(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (AfterCommitEventFailure), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).AfterCommitEventFailure(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.AfterCommitEventFailure, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AfterCommitEventFailure), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AfterCommitEventFailure()
    {
      return this.AfterCommitEventFailure((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus AfterCommitEventFailure(Service service)
    {
      return this.AfterCommitEventFailure(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus AfterCommitEventFailure(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.AfterCommitEventFailure(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus CheckWIPMsgElapsedTime(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (CheckWIPMsgElapsedTime), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).CheckWIPMsgElapsedTime(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.CheckWIPMsgElapsedTime, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CheckWIPMsgElapsedTime), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CheckWIPMsgElapsedTime()
    {
      return this.CheckWIPMsgElapsedTime((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus CheckWIPMsgElapsedTime(Service service)
    {
      return this.CheckWIPMsgElapsedTime(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus CheckWIPMsgElapsedTime(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.CheckWIPMsgElapsedTime(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus CheckWIPMsgRetrievalDate(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (CheckWIPMsgRetrievalDate), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).CheckWIPMsgRetrievalDate(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.CheckWIPMsgRetrievalDate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CheckWIPMsgRetrievalDate), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CheckWIPMsgRetrievalDate()
    {
      return this.CheckWIPMsgRetrievalDate((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus CheckWIPMsgRetrievalDate(Service service)
    {
      return this.CheckWIPMsgRetrievalDate(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus CheckWIPMsgRetrievalDate(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.CheckWIPMsgRetrievalDate(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus ExportInfo_Execute(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (ExportInfo_Execute), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).ExportInfo_Execute(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.ExportInfo_Execute, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExportInfo_Execute), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExportInfo_Execute()
    {
      return this.ExportInfo_Execute((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ExportInfo_Execute(Service service)
    {
      return this.ExportInfo_Execute(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ExportInfo_Execute(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.ExportInfo_Execute(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus ExportInfo_Initialize(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (ExportInfo_Initialize), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).ExportInfo_Initialize(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.ExportInfo_Initialize, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExportInfo_Initialize), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExportInfo_Initialize()
    {
      return this.ExportInfo_Initialize((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ExportInfo_Initialize(Service service)
    {
      return this.ExportInfo_Initialize(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ExportInfo_Initialize(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.ExportInfo_Initialize(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus ExportInfo_Initialize_User(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (ExportInfo_Initialize_User), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).ExportInfo_Initialize_User(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.ExportInfo_Initialize_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExportInfo_Initialize_User), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExportInfo_Initialize_User()
    {
      return this.ExportInfo_Initialize_User((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ExportInfo_Initialize_User(Service service)
    {
      return this.ExportInfo_Initialize_User(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ExportInfo_Initialize_User(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.ExportInfo_Initialize_User(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus ExportInfo_PreExecute(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (ExportInfo_PreExecute), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).ExportInfo_PreExecute(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.ExportInfo_PreExecute, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExportInfo_PreExecute), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExportInfo_PreExecute()
    {
      return this.ExportInfo_PreExecute((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ExportInfo_PreExecute(Service service)
    {
      return this.ExportInfo_PreExecute(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ExportInfo_PreExecute(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.ExportInfo_PreExecute(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus ExportInfo_Validate(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (ExportInfo_Validate), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).ExportInfo_Validate(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.ExportInfo_Validate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExportInfo_Validate), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExportInfo_Validate()
    {
      return this.ExportInfo_Validate((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ExportInfo_Validate(Service service)
    {
      return this.ExportInfo_Validate(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ExportInfo_Validate(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.ExportInfo_Validate(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).GetWIPMsgs(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus GetWIPMsgs(Service service)
    {
      return this.GetWIPMsgs(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.GetWIPMsgs(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus LiveAlert_Initialize(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (LiveAlert_Initialize), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).LiveAlert_Initialize(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.LiveAlert_Initialize, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LiveAlert_Initialize), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LiveAlert_Initialize()
    {
      return this.LiveAlert_Initialize((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus LiveAlert_Initialize(Service service)
    {
      return this.LiveAlert_Initialize(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus LiveAlert_Initialize(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.LiveAlert_Initialize(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus LiveConnect_Initialize(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (LiveConnect_Initialize), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).LiveConnect_Initialize(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.LiveConnect_Initialize, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LiveConnect_Initialize), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LiveConnect_Initialize()
    {
      return this.LiveConnect_Initialize((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus LiveConnect_Initialize(Service service)
    {
      return this.LiveConnect_Initialize(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus LiveConnect_Initialize(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.LiveConnect_Initialize(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus LiveRelay_Initialize(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (LiveRelay_Initialize), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).LiveRelay_Initialize(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.LiveRelay_Initialize, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LiveRelay_Initialize), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LiveRelay_Initialize()
    {
      return this.LiveRelay_Initialize((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus LiveRelay_Initialize(Service service)
    {
      return this.LiveRelay_Initialize(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus LiveRelay_Initialize(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.LiveRelay_Initialize(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus ProcessWIPMsgs(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (ProcessWIPMsgs), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).ProcessWIPMsgs(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.ProcessWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessWIPMsgs), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessWIPMsgs()
    {
      return this.ProcessWIPMsgs((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ProcessWIPMsgs(Service service)
    {
      return this.ProcessWIPMsgs(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ProcessWIPMsgs(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.ProcessWIPMsgs(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus ValidateWIPMsgs(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (ValidateWIPMsgs), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).ValidateWIPMsgs(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.ValidateWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateWIPMsgs), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateWIPMsgs()
    {
      return this.ValidateWIPMsgs((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ValidateWIPMsgs(Service service)
    {
      return this.ValidateWIPMsgs(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ValidateWIPMsgs(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.ValidateWIPMsgs(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus VerifyUser(
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (VerifyUser), (DCObject) service, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).VerifyUser(this._UserProfile, service, parameters, request, out result) : this.AddMethod((Method) new ServiceMethod(service, ServiceMethods.VerifyUser, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (VerifyUser), res, (DCObject) service, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus VerifyUser()
    {
      return this.VerifyUser((Service) null, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus VerifyUser(Service service)
    {
      return this.VerifyUser(service, (Service_Parameters) null, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus VerifyUser(
      Service service,
      Service_Request request,
      out Service_Result result)
    {
      return this.VerifyUser(service, (Service_Parameters) null, request, out result);
    }

    public ResultStatus CommitTransaction(
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      try
      {
        ServiceMethod[] methods = new ServiceMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IServiceService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Service_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Service_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Service cdo,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      try
      {
        return ((IServiceService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Service_Result result1;
        ResultStatus environment = this.GetEnvironment((Service) cdo, (Service_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Service_Request request,
      out Service_Result result)
    {
      return this.GetEnvironment((Service) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Service cdo,
      Service_Request request,
      out Service_Result result)
    {
      result = (Service_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IServiceService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ServiceMethod(cdo, ServiceMethods.ExecuteTransaction, (Service_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Service_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Service) cdo, (Service_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Service cdo)
    {
      return this.ExecuteTransaction(cdo, (Service_Request) null, out Service_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Service_Request request,
      out Service_Result result)
    {
      return this.ExecuteTransaction((Service) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Service cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ServiceMethod(cdo, ServiceMethods.AddDataTransaction, (Service_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((Service) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
