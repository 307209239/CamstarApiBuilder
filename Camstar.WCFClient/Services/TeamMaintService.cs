// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TeamMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TeamMaintService : NamedDataObjectMaintBase
  {
    public TeamMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITeamMaintService), userProfile);
    }

    public ResultStatus Delete(
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) teamMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITeamMaintService) this._Channel).Delete(this._UserProfile, teamMaint, parameters, request, out result) : this.AddMethod((Method) new TeamMaintMethod(teamMaint, TeamMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) teamMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((TeamMaint) null, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus Delete(TeamMaint teamMaint)
    {
      return this.Delete(teamMaint, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus Delete(
      TeamMaint teamMaint,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      return this.Delete(teamMaint, (TeamMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) teamMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITeamMaintService) this._Channel).Freeze(this._UserProfile, teamMaint, parameters, request, out result) : this.AddMethod((Method) new TeamMaintMethod(teamMaint, TeamMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) teamMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((TeamMaint) null, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus Freeze(TeamMaint teamMaint)
    {
      return this.Freeze(teamMaint, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus Freeze(
      TeamMaint teamMaint,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      return this.Freeze(teamMaint, (TeamMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) teamMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITeamMaintService) this._Channel).GetWIPMsgs(this._UserProfile, teamMaint, parameters, request, out result) : this.AddMethod((Method) new TeamMaintMethod(teamMaint, TeamMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) teamMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TeamMaint) null, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(TeamMaint teamMaint)
    {
      return this.GetWIPMsgs(teamMaint, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TeamMaint teamMaint,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      return this.GetWIPMsgs(teamMaint, (TeamMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) teamMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITeamMaintService) this._Channel).Load(this._UserProfile, teamMaint, parameters, request, out result) : this.AddMethod((Method) new TeamMaintMethod(teamMaint, TeamMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) teamMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TeamMaint) null, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus Load(TeamMaint teamMaint)
    {
      return this.Load(teamMaint, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus Load(
      TeamMaint teamMaint,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      return this.Load(teamMaint, (TeamMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TeamMaint teamMaint,
      TeamMaint_LoadESigDetails_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) teamMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITeamMaintService) this._Channel).LoadESigDetails(this._UserProfile, teamMaint, parameters, request, out result) : this.AddMethod((Method) new TeamMaintMethod(teamMaint, TeamMaintMethods.LoadESigDetails, (TeamMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) teamMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TeamMaint) null, (TeamMaint_LoadESigDetails_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus LoadESigDetails(TeamMaint teamMaint)
    {
      return this.LoadESigDetails(teamMaint, (TeamMaint_LoadESigDetails_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TeamMaint teamMaint,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      return this.LoadESigDetails(teamMaint, (TeamMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) teamMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITeamMaintService) this._Channel).New(this._UserProfile, teamMaint, parameters, request, out result) : this.AddMethod((Method) new TeamMaintMethod(teamMaint, TeamMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) teamMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((TeamMaint) null, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus New(TeamMaint teamMaint)
    {
      return this.New(teamMaint, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus New(
      TeamMaint teamMaint,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      return this.New(teamMaint, (TeamMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) teamMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITeamMaintService) this._Channel).NewCopy(this._UserProfile, teamMaint, parameters, request, out result) : this.AddMethod((Method) new TeamMaintMethod(teamMaint, TeamMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) teamMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((TeamMaint) null, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus NewCopy(TeamMaint teamMaint)
    {
      return this.NewCopy(teamMaint, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus NewCopy(
      TeamMaint teamMaint,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      return this.NewCopy(teamMaint, (TeamMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) teamMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITeamMaintService) this._Channel).SaveAs(this._UserProfile, teamMaint, parameters, request, out result) : this.AddMethod((Method) new TeamMaintMethod(teamMaint, TeamMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) teamMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((TeamMaint) null, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus SaveAs(TeamMaint teamMaint)
    {
      return this.SaveAs(teamMaint, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus SaveAs(
      TeamMaint teamMaint,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      return this.SaveAs(teamMaint, (TeamMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      TeamMaint teamMaint,
      TeamMaint_Parameters parameters,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) teamMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITeamMaintService) this._Channel).UnFreeze(this._UserProfile, teamMaint, parameters, request, out result) : this.AddMethod((Method) new TeamMaintMethod(teamMaint, TeamMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) teamMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((TeamMaint) null, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus UnFreeze(TeamMaint teamMaint)
    {
      return this.UnFreeze(teamMaint, (TeamMaint_Parameters) null, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus UnFreeze(
      TeamMaint teamMaint,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      return this.UnFreeze(teamMaint, (TeamMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject teamMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TeamMaint_Result result1;
        ResultStatus resultStatus = this.Delete((TeamMaint) teamMaint, (TeamMaint_Parameters) parameters, (TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject teamMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TeamMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((TeamMaint) teamMaint, (TeamMaint_Parameters) parameters, (TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject teamMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TeamMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TeamMaint) teamMaint, (TeamMaint_LoadESigDetails_Parameters) parameters, (TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject teamMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TeamMaint_Result result1;
        ResultStatus resultStatus = this.New((TeamMaint) teamMaint, (TeamMaint_Parameters) parameters, (TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject teamMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TeamMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((TeamMaint) teamMaint, (TeamMaint_Parameters) parameters, (TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject teamMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TeamMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((TeamMaint) teamMaint, (TeamMaint_Parameters) parameters, (TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject teamMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TeamMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((TeamMaint) teamMaint, (TeamMaint_Parameters) parameters, (TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject teamMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TeamMaint_Result result1;
        ResultStatus resultStatus = this.Load((TeamMaint) teamMaint, (TeamMaint_Parameters) parameters, (TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject teamMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TeamMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TeamMaint) teamMaint, (TeamMaint_Parameters) parameters, (TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      try
      {
        TeamMaintMethod[] methods = new TeamMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITeamMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TeamMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TeamMaint cdo,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      try
      {
        return ((ITeamMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TeamMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((TeamMaint) cdo, (TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      return this.GetEnvironment((TeamMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TeamMaint cdo,
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      result = (TeamMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITeamMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TeamMaintMethod(cdo, TeamMaintMethods.ExecuteTransaction, (TeamMaint_Parameters) null));
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
        TeamMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TeamMaint) cdo, (TeamMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TeamMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (TeamMaint_Request) null, out TeamMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TeamMaint_Request request,
      out TeamMaint_Result result)
    {
      return this.ExecuteTransaction((TeamMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TeamMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TeamMaintMethod(cdo, TeamMaintMethods.AddDataTransaction, (TeamMaint_Parameters) null));
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
        return this.AddDataTransaction((TeamMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
