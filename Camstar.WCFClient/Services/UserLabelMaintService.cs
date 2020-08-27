// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UserLabelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UserLabelMaintService : NamedDataObjectMaintBase
  {
    public UserLabelMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUserLabelMaintService), userProfile);
    }

    public ResultStatus Delete(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) userLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserLabelMaintService) this._Channel).Delete(this._UserProfile, userLabelMaint, parameters, request, out result) : this.AddMethod((Method) new UserLabelMaintMethod(userLabelMaint, UserLabelMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) userLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UserLabelMaint) null, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus Delete(UserLabelMaint userLabelMaint)
    {
      return this.Delete(userLabelMaint, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus Delete(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      return this.Delete(userLabelMaint, (UserLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) userLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserLabelMaintService) this._Channel).Freeze(this._UserProfile, userLabelMaint, parameters, request, out result) : this.AddMethod((Method) new UserLabelMaintMethod(userLabelMaint, UserLabelMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) userLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UserLabelMaint) null, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus Freeze(UserLabelMaint userLabelMaint)
    {
      return this.Freeze(userLabelMaint, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus Freeze(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      return this.Freeze(userLabelMaint, (UserLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) userLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserLabelMaintService) this._Channel).GetWIPMsgs(this._UserProfile, userLabelMaint, parameters, request, out result) : this.AddMethod((Method) new UserLabelMaintMethod(userLabelMaint, UserLabelMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) userLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UserLabelMaint) null, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UserLabelMaint userLabelMaint)
    {
      return this.GetWIPMsgs(userLabelMaint, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      return this.GetWIPMsgs(userLabelMaint, (UserLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) userLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserLabelMaintService) this._Channel).Load(this._UserProfile, userLabelMaint, parameters, request, out result) : this.AddMethod((Method) new UserLabelMaintMethod(userLabelMaint, UserLabelMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) userLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UserLabelMaint) null, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus Load(UserLabelMaint userLabelMaint)
    {
      return this.Load(userLabelMaint, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus Load(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      return this.Load(userLabelMaint, (UserLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_LoadESigDetails_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) userLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserLabelMaintService) this._Channel).LoadESigDetails(this._UserProfile, userLabelMaint, parameters, request, out result) : this.AddMethod((Method) new UserLabelMaintMethod(userLabelMaint, UserLabelMaintMethods.LoadESigDetails, (UserLabelMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) userLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UserLabelMaint) null, (UserLabelMaint_LoadESigDetails_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UserLabelMaint userLabelMaint)
    {
      return this.LoadESigDetails(userLabelMaint, (UserLabelMaint_LoadESigDetails_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      return this.LoadESigDetails(userLabelMaint, (UserLabelMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) userLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserLabelMaintService) this._Channel).New(this._UserProfile, userLabelMaint, parameters, request, out result) : this.AddMethod((Method) new UserLabelMaintMethod(userLabelMaint, UserLabelMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) userLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UserLabelMaint) null, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus New(UserLabelMaint userLabelMaint)
    {
      return this.New(userLabelMaint, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus New(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      return this.New(userLabelMaint, (UserLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) userLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserLabelMaintService) this._Channel).NewCopy(this._UserProfile, userLabelMaint, parameters, request, out result) : this.AddMethod((Method) new UserLabelMaintMethod(userLabelMaint, UserLabelMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) userLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UserLabelMaint) null, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus NewCopy(UserLabelMaint userLabelMaint)
    {
      return this.NewCopy(userLabelMaint, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus NewCopy(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      return this.NewCopy(userLabelMaint, (UserLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) userLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserLabelMaintService) this._Channel).SaveAs(this._UserProfile, userLabelMaint, parameters, request, out result) : this.AddMethod((Method) new UserLabelMaintMethod(userLabelMaint, UserLabelMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) userLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UserLabelMaint) null, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus SaveAs(UserLabelMaint userLabelMaint)
    {
      return this.SaveAs(userLabelMaint, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus SaveAs(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      return this.SaveAs(userLabelMaint, (UserLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) userLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserLabelMaintService) this._Channel).UnFreeze(this._UserProfile, userLabelMaint, parameters, request, out result) : this.AddMethod((Method) new UserLabelMaintMethod(userLabelMaint, UserLabelMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) userLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UserLabelMaint) null, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus UnFreeze(UserLabelMaint userLabelMaint)
    {
      return this.UnFreeze(userLabelMaint, (UserLabelMaint_Parameters) null, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      return this.UnFreeze(userLabelMaint, (UserLabelMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject userLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserLabelMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UserLabelMaint) userLabelMaint, (UserLabelMaint_Parameters) parameters, (UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject userLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserLabelMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UserLabelMaint) userLabelMaint, (UserLabelMaint_Parameters) parameters, (UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject userLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserLabelMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UserLabelMaint) userLabelMaint, (UserLabelMaint_LoadESigDetails_Parameters) parameters, (UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject userLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserLabelMaint_Result result1;
        ResultStatus resultStatus = this.New((UserLabelMaint) userLabelMaint, (UserLabelMaint_Parameters) parameters, (UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject userLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserLabelMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UserLabelMaint) userLabelMaint, (UserLabelMaint_Parameters) parameters, (UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject userLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserLabelMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UserLabelMaint) userLabelMaint, (UserLabelMaint_Parameters) parameters, (UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject userLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserLabelMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UserLabelMaint) userLabelMaint, (UserLabelMaint_Parameters) parameters, (UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject userLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserLabelMaint_Result result1;
        ResultStatus resultStatus = this.Load((UserLabelMaint) userLabelMaint, (UserLabelMaint_Parameters) parameters, (UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject userLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserLabelMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UserLabelMaint) userLabelMaint, (UserLabelMaint_Parameters) parameters, (UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      try
      {
        UserLabelMaintMethod[] methods = new UserLabelMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUserLabelMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UserLabelMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserLabelMaint cdo,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      try
      {
        return ((IUserLabelMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UserLabelMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UserLabelMaint) cdo, (UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      return this.GetEnvironment((UserLabelMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UserLabelMaint cdo,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      result = (UserLabelMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserLabelMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UserLabelMaintMethod(cdo, UserLabelMaintMethods.ExecuteTransaction, (UserLabelMaint_Parameters) null));
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
        UserLabelMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UserLabelMaint) cdo, (UserLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UserLabelMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UserLabelMaint_Request) null, out UserLabelMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result)
    {
      return this.ExecuteTransaction((UserLabelMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UserLabelMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UserLabelMaintMethod(cdo, UserLabelMaintMethods.AddDataTransaction, (UserLabelMaint_Parameters) null));
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
        return this.AddDataTransaction((UserLabelMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
