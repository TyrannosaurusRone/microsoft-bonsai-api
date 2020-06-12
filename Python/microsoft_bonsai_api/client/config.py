
"""
Protocol definitions for bonsai3 library
"""
__copyright__ = "Copyright 2020, Microsoft Corp."

# pyright: strict

from argparse import ArgumentParser
from datetime import datetime
from enum import Enum
import json
import os
import sys
from typing import Any, Dict, List, Optional

# CLI help strings
_ACCESS_KEY_HELP = \
    """
    The access key to use when connecting to the BRAIN server. If
    specified, it will be used instead of any access key
    information stored in a bonsai config file.
    """

_API_HOST_HELP = \
    """
    The api host is the host to which the simulator will connect.
    It has the form http[s]://<hostname>[:<port>]
    """

_WORKSPACE_HELP = \
    """
    This is the value of the workspace.
    """

_SIM_CONTEXT_HELP = \
    """
    This is an opaque string.
    """

class BonsaiClientConfig:
    """Configuration information needed to connect to the service."""
    server = ''  # type: str
    workspace = ''  # type: str
    access_key = ''  # type: str
    simulator_context = ''  # type: str

    def __init__(self,
                 workspace: str='',
                 access_key: str='',
                 server: str='https://api.bons.ai',
                 enable_logging=False,
                 argv: Optional[List[str]]=sys.argv):
        """
        Initialize a config object.
        
        Command line argument switches will take priority over environment variables.
        Environment variables will take priority over initializer parameters.
        """

        # defaults
        self.server = os.getenv('SIM_API_HOST', server)
        self.workspace = os.getenv('SIM_WORKSPACE', workspace)
        self.access_key = os.getenv('SIM_ACCESS_KEY', access_key)
        self.simulator_context = os.getenv('SIM_CONTEXT', '')
        self.enable_logging = enable_logging

        # parse the args last
        if argv:
            self.argparse(argv)


    def argparse(self, argv: List[str]):
        ''' parser command line arguments '''
        parser = ArgumentParser(allow_abbrev=False)

        parser.add_argument('--accesskey', '--access-key', help=_ACCESS_KEY_HELP)
        parser.add_argument('--api-host', help=_API_HOST_HELP)
        parser.add_argument('--workspace', help=_WORKSPACE_HELP)
        parser.add_argument('--sim-context', help=_SIM_CONTEXT_HELP)

        args, remainder = parser.parse_known_args(argv[1:])

        # quiet pyright
        if remainder:
            pass

        # unpack arguments
        if args.accesskey:
            self.access_key = args.accesskey

        if args.api_host:
            self.server = args.api_host

        if args.workspace:
            self.workspace = args.workspace

        if args.sim_context:
            self.simulator_context = args.sim_context
