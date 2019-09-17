﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using PointOfInterestSkillTests.Flow.Utterances;
using System.Collections.Generic;
using Luis;
using Microsoft.Bot.Builder;
using VirtualAssistantSample.Tests.Mocks;
using VirtualAssistantSample.Tests.Utterances;

namespace VirtualAssistantSample.Tests.Utilities
{
    public class DispatchTestUtil
    {
        private static Dictionary<string, IRecognizerConvert> _utterances = new Dictionary<string, IRecognizerConvert>
        {
            { GeneralUtterances.Cancel, CreateIntent(GeneralUtterances.Cancel, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.Escalate, CreateIntent(GeneralUtterances.Escalate, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.FinishTask, CreateIntent(GeneralUtterances.FinishTask, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.GoBack, CreateIntent(GeneralUtterances.GoBack, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.Help, CreateIntent(GeneralUtterances.Help, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.Repeat, CreateIntent(GeneralUtterances.Repeat, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.SelectAny, CreateIntent(GeneralUtterances.SelectAny, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.SelectItem, CreateIntent(GeneralUtterances.SelectItem, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.SelectNone, CreateIntent(GeneralUtterances.SelectNone, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.ShowNext, CreateIntent(GeneralUtterances.ShowNext, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.ShowPrevious, CreateIntent(GeneralUtterances.ShowPrevious, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.StartOver, CreateIntent(GeneralUtterances.StartOver, DispatchLuis.Intent.l_General) },
            { GeneralUtterances.Stop, CreateIntent(GeneralUtterances.Stop, DispatchLuis.Intent.l_General) },
            { FaqUtterances.Overview, CreateIntent(FaqUtterances.Overview, DispatchLuis.Intent.q_Faq) },
            { ChitchatUtterances.Greeting, CreateIntent(ChitchatUtterances.Greeting, DispatchLuis.Intent.q_Chitchat) },
        };

        private static Dictionary<string, IRecognizerConvert> _poiUtterances = new Dictionary<string, IRecognizerConvert>
        {
            { FindPointOfInterestUtterances.WhatsNearby, CreateIntent(FindPointOfInterestUtterances.WhatsNearby, MockDispatchLuis.Intent.poiSkill) }
        };

        public static MockLuisRecognizer CreateRecognizer()
        {
            var recognizer = new MockLuisRecognizer(defaultIntent: CreateIntent(string.Empty, DispatchLuis.Intent.None));
            recognizer.RegisterUtterances(_utterances);
            recognizer.RegisterUtterances(_poiUtterances);
            return recognizer;
        }

        public static DispatchLuis CreateIntent(string userInput, DispatchLuis.Intent intent)
        {
            var result = new DispatchLuis
            {
                Text = userInput,
                Intents = new Dictionary<DispatchLuis.Intent, IntentScore>()
            };

            result.Intents.Add(intent, new IntentScore() { Score = 0.9 });

            result.Entities = new DispatchLuis._Entities
            {
                _instance = new DispatchLuis._Entities._Instance()
            };

            return result;
        }

        public static MockDispatchLuis CreateIntent(string userInput, MockDispatchLuis.Intent intent)
        {
            var result = new MockDispatchLuis
            {
                Text = userInput,
                Intents = new Dictionary<MockDispatchLuis.Intent, IntentScore>()
            };

            result.Intents.Add(intent, new IntentScore() { Score = 0.9 });

            result.Entities = new MockDispatchLuis._Entities
            {
                _instance = new MockDispatchLuis._Entities._Instance()
            };

            return result;
        }
    }
}